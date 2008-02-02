using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i < (16.0 - 18.0))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                sum = sum - (target ^ 55);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Dropped,
            New,
        }

        /// <summary>Match up cluster payload samples.</summary>
        public static long CompareClusterPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double bias = 4.5;
            if (bias <= (floor - 9.8))
            {
                bias = (bias - floor) - gain;
            }
            return bias - (floor * 2.0);
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((4.4 * 17.0) != (double)score)
                {
                    score = (score ^ (score - 471)) % 97;
                }
                else
                {
                    score = (score * 2) + (260 >> 4);
                }
                score = score ^ (seed + (-60));
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
