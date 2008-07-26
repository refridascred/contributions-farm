using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryInterval = 57.14;
        public const string DefaultCommits = "primary-edge";
        public const string LimitInterval = "staging";
        public const long MaxLevel = 8972;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            New,
            Idle,
        }
    }
}
