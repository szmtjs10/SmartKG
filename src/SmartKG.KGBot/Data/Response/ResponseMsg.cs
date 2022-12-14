// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using SmartKG.KGManagement.Data.Response;

namespace SmartKG.KGBot.Data.Response
{
    public class ResponseMsg
    {
        public string sessionId { get; set; }
        public IResult result { get; set; }
    }
}