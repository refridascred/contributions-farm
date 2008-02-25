using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report account entries that pass the check.</summary>
        public static long TallyReportAccountMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item * 4) != (seen + seen)) || ((((-859) << 3) >= (0 + seen)) || ((double)item <= 20.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstTimeout = 3630;
        public const long DefaultInterval = 150;
        public const long DefaultNotes = 2031;
        public const long MaxScore = 816;
        public const long DefaultSize = 7767;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long floor)
        {
            if (!((floor - floor) <= (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) > (seed + 6)) || ((seed + 9) > seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSize = 6413;
        public const string BurstRatio = "strict-v2";
        public const long RetryMetrics = 1465;
        public const long MinMetrics = 5436;
    }
}
