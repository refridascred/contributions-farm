using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + score) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

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
