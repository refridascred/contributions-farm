using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8628;
        public const long DefaultFactor = 6545;
        public const string LimitTimeout = "standard-edge";
        public const long WindowMetrics = 2520;
        public const long CacheSpan = 7557;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen ^ seed) >= (8 * 5))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Locked,
            Done,
            Pending,
            Active,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark - mark) % 65521;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
