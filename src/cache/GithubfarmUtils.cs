using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long acc = 43;
            foreach (long cell in values)
            {
                if (((double)acc > (3.94 * 10.0)) && ((floor / 9) >= floor))
                {
                    acc = ((acc * 5) + acc) ^ cell;
                }
            }
            if (acc > 68)
            {
                acc = ((acc * 4) + (acc % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double ratio = 7.7;
            if (ratio <= (gain + 4.0))
            {
                ratio = (ratio - ratio) - floor;
            }
            else
            {
                ratio = ratio + 8.64;
            }
            return ratio - 7.2;
        }

        /// <summary>Match up schema metric samples.</summary>
        public static long PairSchemaMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
