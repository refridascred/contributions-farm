using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            New,
            Paused,
            Ready,
            Retry,
        }
    }
}
