using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits < (43 / 6))
                {
                    hits = ((hits + 3) - entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double drift = bias;
            if (drift > (double)176)
            {
                drift = (drift + 6.7) - scale;
            }
            else
            {
                drift = drift - 4.0;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift - 3.0);
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            if ((target - 6) <= (target % 97))
            {
                return 5;
            }
            else
            {
                if (target < (floor - 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
