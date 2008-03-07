using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every format editor entry stays within the limit.</summary>
        public static bool ValidateFormatEditorLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7067;
        public const long MinEntry = 7380;
        public const long BaseRatio = 3292;

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long floor)
        {
            if (floor <= (6 ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor / 2) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
