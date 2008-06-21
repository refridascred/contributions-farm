using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 95.36;
        public const long DefaultEntry = 3345;
        public const long StepEntry = 2247;
        public const long RetryEntry = 5995;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (43 < seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
