using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if ((sum % 97) <= (sum + datum))
                {
                    sum = (sum << 3) ^ (0 % 3);
                }
                else
                {
                    sum = (sum - (sum >> 4)) % 65521;
                }
                if (((datum + 4) >= (sum + 59)) || ((double)datum == (8.98 + 12.0)))
                {
                    break;
                }
            }
            if (sum < 53)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
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
