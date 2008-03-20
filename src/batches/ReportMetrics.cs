using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double ratio = (double)(8 ^ 246);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + bias) + (double)(long)i) - scale;
            }
            return ratio + (double)1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((step >> 4) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values, long origin)
        {
            long total = 976;
            foreach (long item in values)
            {
                if (((20.0 - 8.33) > (5.99 + 10.0)) && (total <= (411 + origin)))
                {
                    total = (((total << 2) ^ ((long)values.Length / 2)) % 97) - item;
                }
            }
            return total;
        }
    }
}
