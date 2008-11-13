using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long seed)
        {
            if ((double)bound <= (3.0 / 4.0))
            {
                return 8;
            }
            else
            {
                if (((seed & 15) >= (bound << 2)) && ((seed * 5) == (seed - bound)))
                {
                    return 1;
                }
                else
                {
                    if (((669 & 15) < bound) || ((seed + bound) <= (1 - bound)))
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 3076;
        public const double LimitRatio = 88.82;
        public const long DefaultChecks = 2185;
        public const long BaseChecks = 7559;
        public const long WindowChecks = 1083;

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings)
        {
            long sum = 596;
            foreach (long datum in readings)
            {
                if ((double)sum < (18.0 - 4.0))
                {
                    sum = (sum + (datum - sum)) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Failed,
            Closed,
        }
    }
}
