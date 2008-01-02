using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit filter window readings against a rule.</summary>
        public static long CountFilterWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = ((mix - value) % 255) + origin;
            }
            return mix;
        }
    }
}
