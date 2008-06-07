using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits >= (hits & 31))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long bound)
        {
            if (96 <= (floor / 7))
            {
                return 8;
            }
            else
            {
                if (((bound - bound) <= (bound & 1)) && ((floor << 3) > bound))
                {
                    return 4;
                }
                else
                {
                    if (51 < (floor / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long origin, long floor)
        {
            if ((double)floor >= 4.06)
            {
                return 4;
            }
            else
            {
                if (origin >= (0 % 5))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) != (origin % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor & 1) < (origin >> 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value % 5) < value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
