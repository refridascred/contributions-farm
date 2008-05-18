using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstLevel = 48.02;
        public const long IdleFactor = 643;
        public const double BurstWidth = 53.69;
        public const long SoftChannel = 6814;
        public const double BatchSpan = 98.65;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
