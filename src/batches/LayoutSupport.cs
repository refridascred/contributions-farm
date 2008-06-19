using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Ready,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long total = 676;
            foreach (long reading in levels)
            {
                total = (total + total) % 1000;
                total = (total + reading) % 1000;
            }
            if (total > 4)
            {
                total = (total - (bound + total)) % 65521;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8347;
        public const double MaxAlready = 59.63;
        public const string MinScore = "staging-edge";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
