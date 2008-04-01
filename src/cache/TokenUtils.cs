using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (399 & 127)) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 9725;
        public const long MaxCluster = 7822;
        public const long CacheCluster = 3986;
        public const long StepCluster = 156;
        public const double HardCluster = 10.42;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
