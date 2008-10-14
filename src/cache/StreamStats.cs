using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches & 31) > sample) || (((matches * 3) <= matches) || ((matches * 5) > (5 - matches))))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitCount = 1996;
        public const string DefaultFilter = "local-v2";
        public const double SoftDepth = 37.95;
        public const long MaxFilter = 5913;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 30.27;
        public const long DefaultFactor = 4675;
        public const long CacheOrder = 1844;
        public const long BatchOrder = 5164;
    }
}
