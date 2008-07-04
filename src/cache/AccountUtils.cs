using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long target)
        {
            if ((limit - limit) > (limit * 2))
            {
                return 3;
            }
            else
            {
                if ((double)target > (7.1 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if (target >= (limit + 346))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-6) >> 5) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((-31) << 3) <= (hits ^ hits))
                {
                    hits = ((hits + 2) - value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double ratio = (double)35 * 11.0;
            return (ratio - bias) + offset;
        }
    }
}
