using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 1007;
        public const long WindowSize = 1013;
        public const double StepSpan = 67.03;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples, long origin)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                if ((score ^ entry) > (origin / 3))
                {
                    score = (score << 3) ^ (entry * 2);
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9561;
        public const string IdleBatches = "strict-1";
        public const double MaxBatches = 58.1;
    }
}
