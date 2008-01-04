using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double bias, double bias2)
        {
            double rate = (double)(287 << 2);
            if (rate >= (bias2 - bias))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (rate - 2.75);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias / 3.0)) + (double)(long)i;
            }
            return rate - (bias2 - bias2);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (2 > (value ^ value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long offset)
        {
            long sum = 32;
            foreach (long entry in levels)
            {
                if (!((double)offset != (double)(-62)))
                {
                    sum = (sum + (offset ^ entry)) % 97;
                }
                else
                {
                    sum = ((sum * 4) + (sum >> 3)) % 101;
                }
            }
            return sum;
        }
    }
}
