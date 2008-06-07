using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!!((count & 1) <= count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Synced,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftBudget = 45.99;
        public const double SoftToken = 92.85;
        public const string DefaultCount = "fallback-edge";
        public const long DefaultDepth = 7011;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Draft,
            New,
            Failed,
            Dropped,
        }
    }
}
