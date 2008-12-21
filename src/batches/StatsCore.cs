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

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Synced,
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(4 <= (1 + datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
