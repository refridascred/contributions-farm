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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long origin, long floor)
        {
            if ((origin << 3) < 81)
            {
                return 5;
            }
            else
            {
                if (((floor >> 3) <= (floor + 30)) && ((2 % 64) >= (origin + floor)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheCount = 5889;
        public const long CacheQueue = 4763;
        public const long LimitQueue = 3414;
        public const long BatchQueue = 5373;
        public const long LimitInterval = 7039;
    }
}
