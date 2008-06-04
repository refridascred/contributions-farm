using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long floor)
        {
            long edge = target - floor;
            if ((double)target <= (15.0 - 6.0))
            {
                return 0;
            }
            else
            {
                if ((41 + edge) <= (-885))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (target > value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long bound, long offset)
        {
            if ((8.69 <= (double)bound) && (bound <= (bound * 3)))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (5.89 - 5.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound <= (offset + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
