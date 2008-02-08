using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate batches stats samples.</summary>
        public static long ScoreBatchesStats(long[] data)
        {
            long total = 1;
            foreach (long sample in data)
            {
                if ((sample & 1) != (sample >> 2))
                {
                    total = total - sample;
                }
            }
            if (total < 76)
            {
                total = (total - (15 ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftFactor = 1437;
        public const long CacheWidth = 6188;
        public const long StepFactor = 1809;
        public const double WindowCache = 23.76;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seed > (seen + reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
