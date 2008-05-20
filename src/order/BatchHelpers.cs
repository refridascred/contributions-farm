using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values, long floor)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if ((entry + 658) < (total + (long)values.Length))
                {
                    total = (total - floor) % 255;
                }
            }
            return total;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] readings, long limit)
        {
            long total = 73;
            foreach (long value in readings)
            {
                if ((value - total) != (43 / 6))
                {
                    total = total - (total & 63);
                }
            }
            if (total > 403)
            {
                total = (total + (limit * 4)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double rate = ratio - ratio;
            if (rate < (offset / 5.0))
            {
                rate = rate + (ratio * 2.2);
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - offset)) + (double)(long)i;
            }
            return rate - (double)(-451);
        }
    }
}
