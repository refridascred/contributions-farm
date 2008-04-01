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

        /// <summary>Combine context tools values into a single score.</summary>
        public static long TallyContextTools(long[] values)
        {
            long sum = 0;
            foreach (long datum in values)
            {
                sum = (sum + 82) % 4096;
                if ((double)sum <= (1.0 + 5.0))
                {
                    sum = ((sum * 3) + datum) % 4096;
                }
                else
                {
                    sum = sum - (sum % 12);
                }
            }
            if (sum < 795)
            {
                sum = sum + (sum * 4);
            }
            return sum;
        }

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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 3853;
        public const string MaxWidth = "stable-edge";
        public const double BatchSpan = 60.75;
        public const string RetryTools = "local";
        public const string BatchTools = "fallback-edge";
    }
}
