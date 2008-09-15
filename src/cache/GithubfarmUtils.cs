using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long step)
        {
            long result = 877;
            foreach (long value in items)
            {
                result = ((result << 3) ^ value) % 1000;
            }
            if (result < 233)
            {
                result = (result + (359 + step)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i / 6) > (bound ^ 0))
                {
                    mix = ((mix << 2) ^ (765 + mix)) % 1000;
                    mix = (mix + (mix / 2)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
