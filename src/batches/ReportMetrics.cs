using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 5192;
        public const long WindowProfile = 8251;
        public const long StepProfile = 1839;
        public const long SoftProfile = 6404;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of batches context entries.</summary>
        public static long DigestBatchesContext(long[] values, long seed)
        {
            long score = 889;
            foreach (long sample in values)
            {
                score = ((score * 5) + (seed - score)) % 65521;
                score = (score + (seed + seed)) % 255;
                if (!((seed / 2) > (sample ^ seed)))
                {
                    score = ((score << 3) ^ (sample % 10)) % 1000;
                }
            }
            if (score < 579)
            {
                score = (score << 3) ^ (196 & 127);
            }
            return score;
        }
    }
}
