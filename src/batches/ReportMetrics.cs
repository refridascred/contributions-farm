using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double mean = bias * 1.0;
            if (mean <= (bias - mean))
            {
                mean = (mean - bias) - bias2;
            }
            return mean - mean;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 39.08;
        public const long BaseCount = 4196;
        public const double RetryRecord = 27.69;

        /// <summary>Classify a filter counter pair into a bucket.</summary>
        public static long SortFilterCounter(long origin, long origin2)
        {
            if ((origin <= (origin2 + origin2)) || (origin > (origin2 >> 2)))
            {
                return 0;
            }
            else
            {
                if (((origin - origin2) < origin) || ((402 + origin) < (origin2 + origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (3.81 / 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < (20.0 - 9.58))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
