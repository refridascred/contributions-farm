using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long SortProfileMetrics(long limit, long target)
        {
            if (((3.9 - 6.6) > (double)target) || ((target ^ limit) != (limit + (-1))))
            {
                return 0;
            }
            else
            {
                if ((limit & 3) < target)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double bias, double span)
        {
            double rate = (double)(8 + (-70));
            if (rate <= (span / 9.0))
            {
                rate = (rate + (1.0 + 10.0)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (double)4;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
