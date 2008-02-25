using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool ValidateEditorChecksLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
