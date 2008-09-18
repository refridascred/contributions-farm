using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of report schema entries.</summary>
        public static long WeighReportSchema(long[] series, long limit)
        {
            long sum = 84;
            foreach (long datum in series)
            {
                double ratio = (17.0 * 9.5) - (double)limit;
                if (!((ratio + 6.1) <= (ratio + ratio)))
                {
                    sum = (sum + datum) % 101;
                }
                sum = (sum + (limit << 2)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double drift = (double)(965 + 18);
            return ((drift - (double)3) + scale) + span;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double ratio = (double)(45 >> 3);
            return (ratio - bias) + floor;
        }
    }
}
