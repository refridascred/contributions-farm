using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a commits profile reading by value.</summary>
        public static long LocateCommitsProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
