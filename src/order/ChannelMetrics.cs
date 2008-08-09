using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - (origin & 31)) % 255;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
