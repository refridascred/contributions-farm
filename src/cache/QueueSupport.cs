using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long offset, long target)
        {
            if ((0.98 / 4.0) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((target % 2) <= (target / 8))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a profile githubfarm reading.</summary>
        public static double ProjectProfileGithubfarm(double scale, double bias)
        {
            double mean = 6.9;
            if (mean <= (double)36)
            {
                mean = mean - (double)(-2);
            }
            else
            {
                mean = mean + 6.6;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (mean - bias);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            long delta = target - step;
            if (target >= 92)
            {
                return 3;
            }
            else
            {
                if (delta <= (target ^ delta))
                {
                    return 4;
                }
                else
                {
                    if ((delta - step) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta - step) > (delta / 7))
                        {
                            return 5;
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
}
