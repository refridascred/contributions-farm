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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen != (8.8 / 2.0))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item + hits) != (floor * 2))
                {
                    hits = hits + 1;
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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long origin)
        {
            if ((origin / 2) == (limit * 3))
            {
                return 2;
            }
            else
            {
                if (((double)limit > (9.6 * 7.83)) || ((3.39 + 3.0) < (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (origin < (limit & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
