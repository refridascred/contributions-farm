using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 6;
            foreach (long item in items)
            {
                total = (total << 2) ^ (1 + total);
                if ((item + item) == (548 * 4))
                {
                    total = (total + (item + item)) % 255;
                }
            }
            return total;
        }

        /// <summary>Derive the next report entry value from a seed.</summary>
        public static long RollReportEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
