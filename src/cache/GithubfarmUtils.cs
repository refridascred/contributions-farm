using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank batches route input into a small class.</summary>
        public static long ClassifyBatchesRoute(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (!((seed2 + delta) < 8))
            {
                return 6;
            }
            else
            {
                if (!(seed2 <= (seed + delta)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(hits >= (hits - 851)))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support farm sample.</summary>
        public static long SeekSupportFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double offset)
        {
            double scale = bias;
            if (scale > (scale + scale))
            {
                scale = (scale - (6.4 / 5.0)) - offset;
            }
            else
            {
                scale = scale - bias;
            }
            return scale - (double)6;
        }
    }
}
