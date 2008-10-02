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

        /// <summary>Fold a list of editor batches readings.</summary>
        public static long TallyEditorBatches(long[] series)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ (datum + 6)) % 1000;
            }
            return sum % 65521;
        }
    }
}
