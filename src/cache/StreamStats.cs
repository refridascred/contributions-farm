using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long step)
        {
            if ((double)step > (13.0 - 9.1))
            {
                return 6;
            }
            else
            {
                if ((step + floor) < ((-723) + 974))
                {
                    return 3;
                }
                else
                {
                    if (((double)step == (4.7 + 6.27)) || ((529 - 0) >= (step * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 7) == (step / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of route stats readings.</summary>
        public static long OverlapRouteStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)seed <= (double)matches) && ((matches >> 1) < (matches + matches)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)seed >= (5.0 + 4.1)) || (2.5 <= (double)seen))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
