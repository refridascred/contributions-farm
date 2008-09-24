using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 4741;
        public const double MinFactor = 57.77;
        public const long StepBatches = 8839;
        public const long SoftRatio = 2048;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) != (target & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i == (2.82 - 3.5))
                {
                    score = (score << 3) ^ score;
                }
                else
                {
                    score = score + (long)i;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
