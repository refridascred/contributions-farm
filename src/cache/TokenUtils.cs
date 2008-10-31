using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result * 3) + (5 / 9);
                result = result + 6;
                result = (result + (floor ^ result)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftLevel = 1737;
        public const long MaxInterval = 341;
        public const long RetryDepth = 9219;
        public const string BurstSize = "cached-edge";
        public const double LimitQueue = 65.63;

        /// <summary>Check that every tools batch entry stays within the limit.</summary>
        public static bool GuardToolsBatchLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
