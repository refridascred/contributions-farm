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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((4 + seen) == (item + item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches >= 7.44)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
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
