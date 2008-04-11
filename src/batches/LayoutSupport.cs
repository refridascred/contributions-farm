using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Synced,
            Pending,
            New,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }
    }
}
