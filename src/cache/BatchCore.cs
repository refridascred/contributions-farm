using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long origin)
        {
            if (!((seed * 2) <= (seed + 500)))
            {
                return 8;
            }
            else
            {
                if (!((seed * 2) >= (origin << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 2) >= (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((74 - origin) <= (seed - seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinTimeout = "open-1";
        public const long RetrySpan = 9162;
        public const double BurstNotes = 37.9;

        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long TallyGithubfarmFilterOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (tally + tally))
                {
                    tally = ((tally + 3) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ 310) % 65521;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
