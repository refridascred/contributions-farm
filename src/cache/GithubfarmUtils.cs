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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 2) ^ (state - bound);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
