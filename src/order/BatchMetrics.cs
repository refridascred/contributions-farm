using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series, long seed)
        {
            long score = 990;
            foreach (long reading in series)
            {
                if (4.0 >= (double)seed)
                {
                    score = (score + (reading + reading)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long seed, long limit)
        {
            if ((limit + seed) >= (9 ^ seed))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (9.0 * 5.1))
                {
                    return 0;
                }
                else
                {
                    if (seed < (seed + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long acc = 168;
            foreach (long sample in data)
            {
                if ((sample ^ step) == (sample + step))
                {
                    acc = ((acc << 3) ^ 45) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
