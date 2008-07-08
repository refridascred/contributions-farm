using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 3248;
        public const long HardReport = 9103;
        public const long MaxReport = 3641;

        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long MeasureBatchesChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum * 5) >= (seen * 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
