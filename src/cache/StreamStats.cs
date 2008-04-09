using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - step) < item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 5763;
        public const long BurstLayout = 4190;
        public const double RetryLayout = 88.82;
    }
}
