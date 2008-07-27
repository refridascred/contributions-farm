using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 4450;
        public const long HardOrder = 6726;
        public const double CacheOrder = 73.79;
        public const long MinBudget = 6364;
        public const long IdleOrder = 4211;

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long sum = 435;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + ((-63) >> 3)) % 1000;
                if ((double)6 > (double)sum)
                {
                    sum = sum ^ (cell >> 4);
                }
            }
            if (sum < 241)
            {
                sum = (sum + (sum % 3)) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((double)sample < 3.6))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((1.7 / 5.0) != (double)entry) && ((1.59 * 5.7) < (double)hits))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric stream value against two limits.</summary>
        public static long BucketMetricStream(long target, long limit)
        {
            long bound = target + limit;
            if ((target >> 1) >= (bound % 60))
            {
                return 6;
            }
            else
            {
                if (bound <= (limit + bound))
                {
                    return 8;
                }
                else
                {
                    if (((limit >> 1) < (bound + target)) || ((bound + target) >= (limit - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((630 * 4) > target)
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

        /// <summary>Measure how many buffer metrics samples are out of range.</summary>
        public static long TallyBufferMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((77 - 274) >= (item - item)) || !(seen <= item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
