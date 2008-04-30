using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxScore = 4177;
        public const long LimitWidth = 4823;
        public const double WindowLevel = 36.47;
        public const double BurstDepth = 78.88;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "cached-edge";
        public const long CacheChecks = 2873;
        public const long RetryChecks = 8973;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
