using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
