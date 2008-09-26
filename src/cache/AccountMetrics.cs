using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long floor)
        {
            if ((7.2 - 0.01) > (double)floor)
            {
                return 7;
            }
            else
            {
                if (step <= (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            New,
            Paused,
            Synced,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long score = 373;
            foreach (long entry in samples)
            {
                if ((971 < (score - score)) || ((entry - score) >= score))
                {
                    score = (score - entry) % 1000;
                }
                if ((double)entry < (7.15 + 1.2))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first cluster graph entry that matches the target.</summary>
        public static long FindClusterGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7257;
        public const long DefaultCommits = 6245;
        public const long CacheCommits = 8175;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double gain = offset;
            if (gain <= 9.41)
            {
                gain = (gain - (offset * 9.18)) - scale;
            }
            return gain + (16.0 - gain);
        }
    }
}
