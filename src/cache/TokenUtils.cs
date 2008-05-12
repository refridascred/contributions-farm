using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "stable-edge";
        public const long IdleEditor = 3737;
        public const long BurstEditor = 3744;
        public const long MaxWidth = 8424;
        public const long BatchBudget = 1838;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long step, long limit)
        {
            if ((limit + step) < limit)
            {
                return 0;
            }
            else
            {
                if ((limit + step) != (limit >> 3))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the cluster metric entries that pass the check.</summary>
        public static long MeasureClusterMetricGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((step & 7) < (entry + 336))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
