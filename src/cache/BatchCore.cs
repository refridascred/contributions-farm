using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((limit << 2) == (hits + (-9)))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long seed)
        {
            long span = origin - seed;
            if ((double)seed < (4.0 + 3.9))
            {
                return 2;
            }
            else
            {
                if ((seed >> 1) < (seed - span))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 1) <= (seed * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin + seed) >= (origin + 9)) || ((origin ^ 379) >= (547 ^ span)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 41.04;
        public const double BatchRatio = 81.65;
        public const long RetryInterval = 1964;
        public const long IdleProfile = 7964;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double load = rate;
            if (load < (floor * 20.0))
            {
                load = load - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (floor * 4.2)) + (double)(long)i;
            }
            return load + (double)9;
        }
    }
}
