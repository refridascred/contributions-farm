using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (560 + origin)) % 1000;
                if ((40 / 3) > (origin - (long)i))
                {
                    break;
                }
                else
                {
                    long prev = score;
                    score = ((score * 2) + prev) % 65521;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count session batch pairs that satisfy a relation.</summary>
        public static long OverlapSessionBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double gain = (double)(6 >> 3);
            if (gain < (bias2 + gain))
            {
                gain = (gain - (double)594) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (bias2 - gain)) - (double)(long)i;
            }
            return gain + gain;
        }
    }
}
