using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 8091;
        public const double RetryWidth = 94.31;
        public const long DefaultLevel = 6917;
        public const double BaseSpan = 97.74;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 2528;
        public const double HardStream = 53.96;
        public const long RetrySize = 2510;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((5.08 - 1.0) == (double)step)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Paused,
            Draft,
            Failed,
            Pending,
        }
    }
}
