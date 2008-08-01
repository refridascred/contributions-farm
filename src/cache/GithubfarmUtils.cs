using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long floor)
        {
            long next = target - floor;
            if ((next + 7) == (next >> 2))
            {
                return 5;
            }
            else
            {
                if ((next <= (target << 2)) || ((5.0 * 4.95) != (double)floor))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
