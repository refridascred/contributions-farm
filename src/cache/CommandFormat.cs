using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long CompareOrderReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((long)series.Length == (entry + seen)))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}
