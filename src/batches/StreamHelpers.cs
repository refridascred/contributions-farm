using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum / 3) > matches) || (datum < (matches & 127)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long sum = 94;
            foreach (long value in values)
            {
                if ((double)sum > (8.0 / 8.0))
                {
                    sum = ((((sum << 3) ^ sum) % 1000) ^ value) - bound;
                }
            }
            return sum;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long offset)
        {
            long gap = limit - offset;
            if ((offset % 7) <= (264 + 84))
            {
                return 4;
            }
            else
            {
                if ((double)offset < (double)gap)
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) < (offset & 1)) || ((double)gap >= (5.6 - 4.62)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 24) > (gap + limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Dropped,
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Measure how many stats graph samples are out of range.</summary>
        public static long MeasureStatsGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((cell <= (matches >> 1)) && ((matches - cell) != (7 % 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long limit)
        {
            if (!((7.6 + 19.0) < (double)limit))
            {
                return 8;
            }
            else
            {
                if ((3.98 + 16.0) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((-28) << 2) == (limit + 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 2) == ((-2) + 600))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
