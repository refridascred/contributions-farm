using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a payload already sample.</summary>
        public static long FindPayloadAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((sum + limit) > sum)
                {
                    sum = (sum ^ (236 - (long)i)) % 101;
                    sum = (sum - (limit + sum)) % 65521;
                }
                else
                {
                    sum = (sum * 4) + (sum + limit);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxRatio = 9841;
        public const long BurstAlready = 6498;
        public const long BatchAlready = 5160;
        public const double IdleDepth = 70.82;
    }
}
