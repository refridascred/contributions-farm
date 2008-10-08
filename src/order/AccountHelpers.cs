using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 1168;
        public const long IdleOrder = 6366;
        public const string HardOrder = "strict-1";
        public const double StepFactor = 8.44;
        public const long WindowScore = 9103;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length + 5) > cell)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if ((gap ^ 2) <= (bound2 - bound))
            {
                return 7;
            }
            else
            {
                if (bound2 <= (gap + bound2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a metric profile pair into a bucket.</summary>
        public static long SortMetricProfile(long target, long step)
        {
            if (((double)step > (4.9 + 0.01)) && ((15.0 + 2.7) < (double)target))
            {
                return 3;
            }
            else
            {
                if ((double)target > (5.0 * 2.1))
                {
                    return 7;
                }
                else
                {
                    if (((4 << 1) != (1 - step)) && ((target + step) < (target ^ step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step <= 1.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long offset)
        {
            if (((bound - offset) < (31 - bound)) || ((83 + bound) < offset))
            {
                return 2;
            }
            else
            {
                if (((20 * 3) == (bound + bound)) || ((bound & 1) <= bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
