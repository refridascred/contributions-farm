using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryScore = 5609;
        public const long IdleSize = 7180;
        public const double MaxDepth = 26.61;
        public const long CacheSchema = 5026;
        public const double BaseRatio = 80.64;

        /// <summary>Grade a session entry value against two limits.</summary>
        public static long GradeSessionEntry(long step, long offset)
        {
            if (offset >= (step & 1))
            {
                return 1;
            }
            else
            {
                if (((-767) >> 1) < step)
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset < (1.01 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long CountSupportOrderOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((double)item > (double)step) && (hits <= (hits / 6)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
