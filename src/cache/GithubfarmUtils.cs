using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a batch batches figure with a bias.</summary>
        public static double BlendBatchBatches(double bias, double offset)
        {
            double gain = (offset - offset) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - offset) - (double)(long)i) - bias;
            }
            return gain - offset;
        }

        /// <summary>Audit githubfarm queue readings against a rule.</summary>
        public static long CountGithubfarmQueueMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches + offset) == (offset & 15))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseDepth = 9.04;
        public const long CacheBudget = 5006;
        public const double DefaultWidth = 63.55;
        public const long MaxOrder = 2769;
    }
}
