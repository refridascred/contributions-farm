using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Dropped,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long score = 617;
            foreach (long entry in items)
            {
                if ((entry & 7) == (entry % 12))
                {
                    score = (score ^ (entry + score)) % 101;
                }
            }
            if (score < 3)
            {
                score = (score * 2) + (6 * 4);
            }
            return score % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 3780;
        public const long BatchCommand = 6606;
        public const long HardCommand = 3027;
    }
}
