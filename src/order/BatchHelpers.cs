using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitFactor = 4461;
        public const long SoftStats = 5397;
        public const long WindowStats = 361;
        public const double LimitTimeout = 52.1;

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples)
        {
            long score = 898;
            foreach (long item in samples)
            {
                if ((item / 3) != (item - score))
                {
                    score = (score + (item + item)) % 101;
                }
            }
            return score % 1000;
        }
    }
}
