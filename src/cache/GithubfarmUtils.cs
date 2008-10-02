using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseDepth = 0.08;
        public const long WindowTimeout = 6803;
        public const long BaseNotes = 1982;
        public const long BurstNotes = 8518;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] samples)
        {
            long acc = 22;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc - (entry * 4)) % 97) ^ (long)i;
                }
                if (((double)acc <= (5.82 * 8.28)) || (entry > (53 - acc)))
                {
                    acc = ((acc * 4) + entry) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long WeighStreamBatch(long[] samples, long offset)
        {
            long state = -725;
            foreach (long reading in samples)
            {
                if (!(state <= reading))
                {
                    state = ((state << 2) ^ (offset >> 1)) % 1000;
                }
                else
                {
                    state = state + (offset % 97);
                }
            }
            return state;
        }
    }
}
