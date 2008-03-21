using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next tools queue value.</summary>
        public static double ProjectToolsQueue(double rate, double bias)
        {
            double rate2 = 6.86;
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + bias) - (double)(long)i;
            }
            return rate2 + (rate * 13.0);
        }

        /// <summary>Rank stream metric input into a small class.</summary>
        public static long SortStreamMetric(long origin, long seed)
        {
            long slot = origin + seed;
            if (seed <= (slot << 2))
            {
                return 5;
            }
            else
            {
                if ((slot > origin) || ((slot >> 2) <= origin))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 53;
            foreach (long value in levels)
            {
                long lane = carry;
                if (((double)lane < (6.0 / 7.0)) || ((8.4 - 6.4) > (double)carry))
                {
                    lane = (lane - (lane - carry)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ (value + 39)) % 4096;
                    lane = (lane - (95 + carry)) % 1000;
                }
                carry = (carry ^ (value - value)) % 1000;
            }
            return carry;
        }
    }
}
