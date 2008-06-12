using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Active,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((double)reading < (double)bound) && ((double)reading >= (double)seen)) && !((seen ^ 3) >= bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cache context readings.</summary>
        public static long CompareCacheContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 3156;
        public const long BurstProfile = 6061;
        public const long BaseSize = 5911;
        public const long IdleProfile = 7573;
        public const long BatchProfile = 2240;
    }
}
