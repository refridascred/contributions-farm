using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "staging-v2";
        public const long BatchTimeout = 1055;
        public const string BaseGithubfarm = "fallback-1";

        /// <summary>Count metrics token pairs that satisfy a relation.</summary>
        public static long CompareMetricsTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of commits window readings.</summary>
        public static long TotalCommitsWindow(long[] items)
        {
            long mark = -25;
            foreach (long entry in items)
            {
                if (entry >= (entry + mark))
                {
                    mark = (mark ^ (mark & 15)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples)
        {
            long anchor = 526;
            foreach (long reading in samples)
            {
                if ((47 % 12) <= (reading & 255))
                {
                    anchor = (anchor << 2) ^ (27 % 3);
                }
            }
            return anchor % 65521;
        }
    }
}
