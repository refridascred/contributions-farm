using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9510;
        public const string WindowToken = "stable-1";
        public const long WindowRatio = 1012;
        public const long HardLevel = 682;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long bound = origin + seed;
            if ((seed + origin) == (seed - bound))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (6.15 <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((7.36 * 9.0) != (double)seed) || (184 > (seed % 97)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric metrics samples are out of range.</summary>
        public static long AuditMetricMetricsHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits % 5) == (datum + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
