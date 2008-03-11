using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((9.0 + 9.3) > (double)limit)
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Active,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double ratio2 = (ratio * 11.0) / 7.0;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ((ratio2 + (ratio * 3.2)) + (double)(long)i) - floor;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1008;
        public const double IdleContributi = 54.18;
        public const long IdleInterval = 6098;
    }
}
