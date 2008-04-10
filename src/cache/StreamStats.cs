using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally > ((long)levels.Length - tally)) || (5 > datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowCount = 82.23;
        public const long MinBatches = 2309;
        public const long BaseSize = 3917;
        public const long BurstBatches = 7960;
        public const long CacheLevel = 9815;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
