using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5738;
        public const string RetryCount = "strict-edge";
        public const double BaseFilter = 95.7;
        public const long MinDepth = 410;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "latest-1";
        public const long RetryCache = 2519;
        public const long BurstCache = 4880;
        public const long IdleSpan = 7276;
        public const long LimitLevel = 6775;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double rate = floor;
            if (rate >= (scale - 6.8))
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (scale - 1.83);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((9 ^ sample) > (seen << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
