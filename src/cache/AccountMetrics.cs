using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8817;
        public const double MaxTimeout = 57.72;
        public const double BurstDepth = 39.07;
        public const long DefaultScore = 5541;
        public const long MaxReport = 4050;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((long)values.Length - tally) != (tally % 16))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Pending,
            Done,
            New,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCount = "stable-edge";
        public const long LimitFactor = 391;
        public const long HardCommits = 5775;
        public const double LimitCommits = 34.93;

        /// <summary>Validate notes payload readings against a bound.</summary>
        public static bool GuardNotesPayloadBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
