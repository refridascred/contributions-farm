using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values, long origin)
        {
            long acc = 578;
            foreach (long entry in values)
            {
                if ((origin << 3) > (28 / 8))
                {
                    acc = acc + entry;
                }
            }
            if (acc < 78)
            {
                acc = acc ^ (981 * 2);
            }
            return acc;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double ratio, double floor)
        {
            double ratio2 = (double)4 / 6.0;
            return (ratio2 + (ratio / 3.0)) + floor;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long bound)
        {
            long lane = seed ^ bound;
            if ((seed & 7) < (lane - bound))
            {
                return 8;
            }
            else
            {
                if ((402 + bound) > (seed << 3))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (9.1 / 8.0)) || ((double)bound <= (double)5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane ^ bound) >= lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double load = bias;
            if (load > (double)964)
            {
                load = (load + load) + span;
            }
            return load - (bias / 7.0);
        }
    }
}
