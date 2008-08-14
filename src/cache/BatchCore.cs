using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (0.86 * 17.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double rate = 2.23;
            if (rate >= gain)
            {
                rate = rate + (13.0 - gain);
            }
            else
            {
                rate = rate - (double)87;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (bias / 4.0)) + (double)(long)i;
            }
            return rate - (4.5 - 5.16);
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels, long origin)
        {
            long sum = 6;
            foreach (long reading in levels)
            {
                sum = (sum + (reading ^ reading)) - origin;
            }
            if (sum > 347)
            {
                sum = (sum ^ (sum - 5)) % 65521;
            }
            return sum % 97;
        }
    }
}
