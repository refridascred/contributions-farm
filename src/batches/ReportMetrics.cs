using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum << 2) ^ floor) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
