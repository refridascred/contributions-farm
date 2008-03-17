using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long total = 379;
            foreach (long item in items)
            {
                if ((double)total != (0.86 * 4.7))
                {
                    total = (total * 3) + ((long)items.Length >> 2);
                }
                else
                {
                    total = ((total * 2) + (item + item)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score << 3) ^ (long)i2) % 101;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double ratio = (double)(94 >> 4);
            if (ratio > (double)(-6))
            {
                ratio = ratio - (ratio * 7.25);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (9.6 + scale)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
