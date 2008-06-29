using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series)
        {
            long carry = 88;
            foreach (long reading in series)
            {
                if (((reading >> 4) > (carry >> 2)) && (carry <= reading))
                {
                    carry = ((carry * 2) + (carry + reading)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Stale,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "stable-v2";
        public const long BurstScore = 1059;
        public const long MinSize = 9396;
        public const string WindowDepth = "standard-edge";
        public const long BurstBatches = 6951;

        /// <summary>Digest a series of farm notes entries.</summary>
        public static long TallyFarmNotes(long[] values, long bound)
        {
            long result = -6;
            foreach (long item in values)
            {
                if ((5.19 + 7.96) < (double)bound)
                {
                    result = ((result * 5) + (408 - item)) % 97;
                }
            }
            return result % 4096;
        }
    }
}
