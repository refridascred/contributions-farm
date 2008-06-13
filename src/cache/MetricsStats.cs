using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats support readings.</summary>
        public static long TallyStatsSupport(long[] readings, long floor)
        {
            long score = 45;
            foreach (long sample in readings)
            {
                if (floor > (floor & 3))
                {
                    score = (score + (score << 2)) % 97;
                }
                score = (score - (score + sample)) % 97;
            }
            if (score < 333)
            {
                score = (score - (floor * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 3988;
        public const double StepBudget = 89.1;
        public const long CacheGithubfarm = 7531;
        public const string HardCount = "stable-edge";

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if ((2.0 + 8.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset / 5) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next schema cluster value.</summary>
        public static double BlendSchemaCluster(double ratio, double floor)
        {
            double scale = floor;
            if (scale >= (scale * 2.16))
            {
                scale = scale + (double)30;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)78) + (double)(long)i;
            }
            return scale - (ratio / 5.0);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long origin)
        {
            long slot = target ^ origin;
            if (((target >> 1) >= target) && ((origin + slot) != (origin + target)))
            {
                return 6;
            }
            else
            {
                if (!(target > (target >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (slot <= (slot ^ target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
