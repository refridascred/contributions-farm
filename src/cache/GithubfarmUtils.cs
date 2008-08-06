using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Closed,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Accumulate githubfarm farm samples.</summary>
        public static long CombineGithubfarmFarm(long[] values)
        {
            long anchor = 931;
            foreach (long cell in values)
            {
                if ((8.2 / 5.0) == (double)anchor)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 255) - cell;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor * 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftBudget = 4027;
        public const double MaxRoute = 96.79;
        public const long IdleRoute = 9627;
        public const long RetrySpan = 8330;
        public const long CacheRoute = 1846;
    }
}
