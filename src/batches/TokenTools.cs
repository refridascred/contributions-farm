using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((bound >> 4) <= (bound >> 2)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
