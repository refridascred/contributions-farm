using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of cache checks entries.</summary>
        public static long TallyCacheChecks(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                mix = ((mix - (mix >> 1)) % 65521) + item;
            }
            if (mix < 17)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 5924;
        public const long IdleToken = 1886;
        public const string DefaultFactor = "open";
        public const long DefaultInterval = 8886;
        public const long MaxToken = 7559;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
