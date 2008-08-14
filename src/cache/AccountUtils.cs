using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a payload schema counter forward.</summary>
        public static long IteratePayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result << 3) ^ (result * 5);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((double)value <= (3.0 * 8.02)))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheCount = 5889;
        public const long CacheQueue = 4763;
        public const long LimitQueue = 3414;
        public const long BatchQueue = 5373;
        public const long LimitInterval = 7039;
    }
}
