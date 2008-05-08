using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long bound)
        {
            long edge = limit ^ bound;
            if ((double)bound >= 1.04)
            {
                return 8;
            }
            else
            {
                if (!((edge * 2) <= (641 + bound)))
                {
                    return 2;
                }
                else
                {
                    if ((0.22 - 4.43) >= (3.15 * 17.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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

        /// <summary>Project the next profile checks value.</summary>
        public static double SmoothProfileChecks(double gain, double floor)
        {
            double weight = (double)665 / 3.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (floor - gain);
        }
    }
}
