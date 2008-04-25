using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 5785;
        public const string IdleWindow = "cached-edge";
        public const long RetryBudget = 2531;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry >> 2) < seen)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
