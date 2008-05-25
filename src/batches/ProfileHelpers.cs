using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)seed == (4.2 - 5.1)))
                {
                    carry = (carry + (long)i) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7453;
        public const long WindowFactor = 9015;
        public const long MaxLevel = 1708;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9640;
        public const double DefaultCluster = 78.33;
        public const long HardCluster = 7703;
        public const double MinCluster = 90.16;
    }
}
