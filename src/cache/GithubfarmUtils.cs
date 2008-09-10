using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series)
        {
            long total = 685;
            foreach (long datum in series)
            {
                if ((8.23 * 6.8) < (double)total)
                {
                    total = total + (709 % 100);
                }
                else
                {
                    total = (total << 2) ^ (datum + 58);
                }
            }
            if (total > 84)
            {
                total = (total - (total / 3)) % 1000;
            }
            return total;
        }
    }
}
