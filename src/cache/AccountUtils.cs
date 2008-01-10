using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long step2)
        {
            if ((99 / 7) != (step - step))
            {
                return 2;
            }
            else
            {
                if ((step - step) < (4 >> 4))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double floor)
        {
            double gain2 = floor * 11.0;
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 + (floor * 16.0)) + (double)(long)i) + gain;
            }
            return gain2 + (5.25 / 3.0);
        }
    }
}
