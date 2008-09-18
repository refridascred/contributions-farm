using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 91.14;
        public const long LimitRecord = 4324;
        public const long BaseScore = 313;
        public const long MaxSize = 9403;
        public const double HardRecord = 25.02;

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 1435;
        public const long MinWidth = 7071;
        public const string MaxSchema = "staging-v2";
        public const long IdleSchema = 8865;
        public const long BatchLevel = 4797;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry < (entry ^ entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
