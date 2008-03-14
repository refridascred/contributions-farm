using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long origin)
        {
            long next = offset + origin;
            if ((next <= (offset / 6)) && ((offset ^ next) <= (next << 1)))
            {
                return 1;
            }
            else
            {
                if ((84 + offset) == (offset >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((17.0 + 1.0) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((next ^ origin) < next) && ((9 * 5) == (origin % 100)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats githubfarm readings.</summary>
        public static long WeighStatsGithubfarm(long[] items, long offset)
        {
            long state = 4;
            foreach (long reading in items)
            {
                if ((24 + offset) == ((long)items.Length - reading))
                {
                    state = state - reading;
                }
                else
                {
                    state = (state - (offset + 42)) % 1000;
                    state = ((state << 2) ^ offset) % 101;
                }
                if (state < 632)
                {
                    state = state - (reading >> 3);
                }
                if (((state % 3) < (reading + (long)items.Length)) && ((double)reading != (double)offset))
                {
                    state = (state - (offset / 2)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchCount = 14.61;
        public const long RetryRatio = 4691;
        public const double MaxDepth = 83.31;
        public const string RetryLevel = "local-v2";
        public const long HardScore = 1084;

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long limit, long origin)
        {
            long bound = limit + origin;
            if ((limit << 2) != (limit + 56))
            {
                return 3;
            }
            else
            {
                if (15.0 > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (origin <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - bound) < (origin * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long score = 908;
            foreach (long cell in levels)
            {
                score = ((score - score) % 4096) + cell;
            }
            return score;
        }
    }
}
