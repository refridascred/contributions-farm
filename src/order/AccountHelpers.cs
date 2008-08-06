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

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches < (8.1 - 0.62))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftCount = 8851;
        public const string BaseLevel = "local-edge";
        public const string BatchLevel = "legacy-1";
        public const long DefaultSession = 350;
        public const double CacheSession = 20.51;
    }
}
