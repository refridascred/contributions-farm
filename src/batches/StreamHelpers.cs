using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Draft,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + hits) > (414 % 10))
                {
                    hits = ((hits + 1) + datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] values)
        {
            long acc = 261;
            foreach (long value in values)
            {
                if ((value / 5) == (value - acc))
                {
                    acc = (acc << 2) ^ (48 + value);
                }
                if ((value ^ acc) == (value + value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of route editor readings.</summary>
        public static long TotalRouteEditor(long[] samples, long seed)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if ((seed ^ cell) > (seed + result))
                {
                    result = result - (seed / 7);
                }
                else
                {
                    result = result + (seed & 127);
                }
            }
            if (result > 9)
            {
                result = (result + (-490)) % 101;
            }
            return result;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long limit)
        {
            if ((limit + limit) <= (step << 2))
            {
                return 2;
            }
            else
            {
                if (!((12 >> 1) < step))
                {
                    return 8;
                }
                else
                {
                    if ((step & 3) == (step / 5))
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

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long bound)
        {
            if ((double)bound <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (!(bound > (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    if (bound > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
