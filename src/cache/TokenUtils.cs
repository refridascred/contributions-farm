using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a order context counter forward.</summary>
        public static long DeriveOrderContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum * 4) + (target - sum);
                if ((17.0 * 5.7) != (double)(long)i)
                {
                    continue;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)(long)i) + scale;
            }
            return load + (double)4;
        }
    }
}
