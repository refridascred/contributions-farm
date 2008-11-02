using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values, long offset)
        {
            long mix = -63;
            foreach (long entry in values)
            {
                mix = mix ^ (offset - (long)values.Length);
                if ((17.0 - 7.77) == (double)offset)
                {
                    mix = (mix + (entry ^ offset)) % 1000;
                }
                if (27 > (entry + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((14.0 - 6.94) <= (double)value)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseWidth = 6677;
        public const long SoftFactor = 6742;
        public const long BurstLevel = 6778;
        public const double CacheInterval = 69.39;
        public const long BurstSession = 5086;
    }
}
