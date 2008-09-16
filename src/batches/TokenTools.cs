using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((6 - matches) >= reading) || ((double)matches != (10.0 - 3.28))) || ((matches << 1) <= (matches / 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5079;
        public const long BaseRecord = 6840;
        public const double CacheRecord = 71.38;
        public const string SoftLevel = "legacy-1";
    }
}
