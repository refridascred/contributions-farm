using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples, long seed)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                if (((mark + seed) == ((-2) << 2)) && ((7.22 - 3.95) != (double)value))
                {
                    mark = ((mark << 2) ^ (mark + seed)) % 65521;
                }
                else
                {
                    mark = (mark << 2) ^ (seed + mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchCount = "latest-1";
        public const long HardContributi = 9429;
        public const long HardRatio = 3382;
        public const long WindowContributi = 2882;
        public const double LimitContributi = 95.2;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Queued,
            New,
        }
    }
}
