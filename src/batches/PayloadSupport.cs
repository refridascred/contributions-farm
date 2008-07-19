using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long result = 60;
            foreach (long sample in samples)
            {
                result = (result - (sample - sample)) % 97;
            }
            return result % 97;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 85.12;
        public const string IdleBatches = "primary-1";
        public const long LimitBatches = 1167;
        public const long MaxCount = 9339;
        public const double SoftSize = 45.83;
    }
}
