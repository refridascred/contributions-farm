using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstDepth = 7600;
        public const long SoftRecord = 817;
        public const double BurstBudget = 56.48;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum - seed) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    sum = ((sum ^ sum) % 101) + (long)i3;
                    sum = ((sum << 3) ^ (seed / 3)) % 65521;
                }
                if (((long)i % 24) < (-759))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 5) + seed) % 65521;
                    sum = ((sum << 3) ^ sum) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
