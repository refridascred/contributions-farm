using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 8516;
        public const long IdleInterval = 1097;
        public const long StepInterval = 3803;
        public const long LimitAlready = 6690;
        public const string MinLevel = "legacy-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 387;
        public const long BaseRecord = 3089;
        public const long StepBudget = 9547;
        public const double SoftSpan = 8.04;
    }
}
