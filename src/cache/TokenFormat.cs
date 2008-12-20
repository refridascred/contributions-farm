using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7295;
        public const string LimitLevel = "fallback-edge";
        public const long CacheNotes = 5482;
        public const double BatchLevel = 70.13;
    }
}
