using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSpan = 4525;
        public const long SoftLevel = 9002;
        public const double SoftBudget = 68.64;
        public const long IdleTimeout = 7098;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally * 5) < tally)
                {
                    tally = ((tally + 2) + entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long sum = -74;
            foreach (long reading in readings)
            {
                if (!((sum ^ reading) >= (floor ^ reading)))
                {
                    sum = sum ^ (sum ^ floor);
                }
            }
            if (sum > (-193))
            {
                sum = (sum ^ floor) % 255;
            }
            return sum;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double floor)
        {
            double load = 2.13;
            if (load < (floor + bias))
            {
                load = load - 16.0;
            }
            else
            {
                load = load + (load / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + load;
        }
    }
}
