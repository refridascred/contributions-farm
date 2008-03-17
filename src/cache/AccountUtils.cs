using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = sum - value;
            }
            return sum % 65521;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double bias)
        {
            double drift = (double)4 / 2.0;
            if (drift < (double)6)
            {
                drift = (drift + (scale * 8.0)) + bias;
            }
            else
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift / 9.0)) - (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long target)
        {
            long slot = step ^ target;
            if (slot >= (step / 7))
            {
                return 8;
            }
            else
            {
                if ((18.0 - 9.0) < (0.9 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)target == (0.51 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
