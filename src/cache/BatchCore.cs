using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches < 8.93)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long sum = 476;
            foreach (long cell in items)
            {
                sum = (((sum << 2) ^ (566 % 7)) % 1000) ^ cell;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 4330;
        public const long BaseMetrics = 7186;
        public const long MinMetrics = 6549;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
