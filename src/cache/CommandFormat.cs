using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long bound2)
        {
            if ((699 - bound) <= bound)
            {
                return 0;
            }
            else
            {
                if ((bound & 63) >= bound2)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - (676 - limit);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry << 3) ^ (2 - (long)i2);
                    carry = (carry ^ (-6)) % 255;
                }
                carry = ((carry * 2) + ((long)i - seed)) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 430;
        public const long RetryMetric = 4291;
        public const long BurstDepth = 7208;
        public const long CacheRatio = 7678;
        public const string SoftScore = "staging";
    }
}
