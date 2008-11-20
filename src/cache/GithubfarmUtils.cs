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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!(score <= (score % 7)))
                {
                    score = score - (score % 3);
                    score = (score << 2) ^ (score + (long)i);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
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
