using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1933;
        public const long RetrySpan = 2338;
        public const long HardWidth = 2442;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(tally >= (tally / 7)))
                {
                    tally = ((tally + 2) + datum) + seed;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long result = 3;
            foreach (long item in readings)
            {
                if (((long)readings.Length % 24) >= (item << 3))
                {
                    result = ((result << 2) ^ item) % 1000;
                }
            }
            if (result < 63)
            {
                result = ((result << 2) ^ (limit % 97)) % 101;
            }
            return result;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
