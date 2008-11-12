using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long step)
        {
            if (((bound + 15) >= bound) || ((double)bound >= (4.39 / 2.0)))
            {
                return 5;
            }
            else
            {
                if ((bound & 1) != (step + 29))
                {
                    return 4;
                }
                else
                {
                    if ((bound + 702) <= (bound << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long target)
        {
            long gap = floor - target;
            if (((double)target == (19.0 + 2.0)) || ((floor * 3) == (target + target)))
            {
                return 1;
            }
            else
            {
                if (((gap * 2) < (target + 84)) && ((target - floor) == (floor * 5)))
                {
                    return 6;
                }
                else
                {
                    if (((double)gap != (17.0 / 3.0)) && ((gap - floor) != (target + gap)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)gap == (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (origin < (item / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats commits input into a small class.</summary>
        public static long ClassifyStatsCommits(long seed, long origin)
        {
            if (((seed + origin) <= seed) && (origin <= (origin & 63)))
            {
                return 6;
            }
            else
            {
                if (852 <= origin)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
