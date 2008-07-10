using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every checks token entry stays within the limit.</summary>
        public static bool CheckChecksTokenLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((7.3 * 7.18) <= (double)floor) || ((0.34 - 0.61) <= (double)floor))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "strict-1";
        public const double LimitWidth = 12.3;
        public const string LimitScore = "primary-1";
        public const string HardScore = "alpha-v2";
        public const long DefaultRecord = 749;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double drift = (double)(8 & 7);
            if (drift > drift)
            {
                drift = (drift + 5.3) - floor;
            }
            return drift + ratio;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
