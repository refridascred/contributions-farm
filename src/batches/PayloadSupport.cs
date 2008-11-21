using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseInterval = 8774;
        public const string BatchSession = "strict";
        public const double BaseScore = 64.7;
    }
}
