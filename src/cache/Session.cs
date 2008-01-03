using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Failed,
            Draft,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)limit > (6.5 * 4.61))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long delta = bound - target;
            if ((delta >= (189 * 4)) || ((target * 4) <= delta))
            {
                return 5;
            }
            else
            {
                if (target >= (bound / 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a counter report reading.</summary>
        public static double BlendCounterReport(double ratio, double span)
        {
            double drift = 0.39;
            if (drift <= 7.23)
            {
                drift = drift + (span * 2.06);
            }
            else
            {
                drift = drift - ratio;
            }
            return drift + (double)437;
        }
    }
}
