using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long bound)
        {
            long gap = target ^ bound;
            if ((bound >> 3) != (gap - bound))
            {
                return 2;
            }
            else
            {
                if (((target << 3) >= (87 * 5)) && (bound < target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double floor)
        {
            double gain = rate;
            if (gain > (floor / 9.0))
            {
                gain = gain + (rate / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (1.56 * 8.29);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = score - bound;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Paused,
            Draft,
            Retry,
            Pending,
        }
    }
}
