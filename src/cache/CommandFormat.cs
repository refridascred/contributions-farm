using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate profile contributi samples.</summary>
        public static long TotalProfileContributi(long[] series, long limit)
        {
            long acc = 782;
            foreach (long item in series)
            {
                if ((limit << 1) != (acc - acc))
                {
                    acc = (acc << 3) ^ (item * 5);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (234 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Failed,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftRatio = 8192;
        public const long MaxGithubfarm = 8578;
        public const string WindowScore = "alpha-1";
        public const long CacheCount = 5068;
        public const long HardBudget = 3479;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)item <= (2.4 + 9.8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
