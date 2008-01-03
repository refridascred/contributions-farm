using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double rate = (ratio + span) * 4.07;
            if (rate <= (ratio + span))
            {
                rate = rate - 11.0;
            }
            else
            {
                rate = rate - (rate / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate - ratio)) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Locate a order command reading by value.</summary>
        public static long LookupOrderCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter contributi series from a seed.</summary>
        public static long RollCounterContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                if (!(sum <= ((long)i ^ sum)))
                {
                    sum = ((sum * 5) + target) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
