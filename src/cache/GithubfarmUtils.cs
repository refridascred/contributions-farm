using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data, long seed)
        {
            long acc = 66;
            foreach (long sample in data)
            {
                acc = ((acc << 3) ^ (seed - acc)) % 1000;
                acc = (acc + (acc + sample)) % 255;
            }
            if (acc < 22)
            {
                acc = (acc * 3) + (seed / 9);
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxCount = 7518;
        public const long CacheBudget = 591;
        public const double BaseEntry = 27.82;
        public const long LimitEntry = 481;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
