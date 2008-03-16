using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                if (!((score - 852) != (score + seed)))
                {
                    score = ((score - (4 - seed)) % 97) + datum;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
