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

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long step)
        {
            if ((step % 16) < (step ^ target))
            {
                return 1;
            }
            else
            {
                if (((double)step > (0.16 / 4.0)) && ((double)target <= 20.0))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
