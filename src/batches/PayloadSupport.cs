using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowFactor = 2490;
        public const string StepBatches = "cached";
        public const double BatchScore = 23.05;
        public const long LimitBatches = 3649;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
