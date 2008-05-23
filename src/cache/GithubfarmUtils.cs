using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many cluster farm samples are out of range.</summary>
        public static long TallyClusterFarmHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample / 7) > (8 * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a metrics cluster figure with a bias.</summary>
        public static double ProjectMetricsCluster(double gain, double floor)
        {
            double rate = (double)258 / 9.0;
            if (rate > floor)
            {
                rate = rate - gain;
            }
            return rate + 0.7;
        }

        /// <summary>Iterate the cache batches series from a seed.</summary>
        public static long DeriveCacheBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if (score <= (target + target))
                {
                    continue;
                }
                else
                {
                    score = (score + score) % 4096;
                }
                score = (score * 3) + ((long)i - 489);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double ratio = (double)(44 + (-4));
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (offset - offset)) + (double)(long)i) - bias;
            }
            return ratio + (double)(-11);
        }
    }
}
