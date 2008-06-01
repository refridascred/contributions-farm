using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(entry > (822 - step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph cluster samples are out of range.</summary>
        public static long CountGraphClusterOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches - matches) != (701 + matches))
                {
                    matches = ((matches + 1) + item) + seed;
                }
            }
            return matches;
        }

        /// <summary>Rank record layout input into a small class.</summary>
        public static long BucketRecordLayout(long floor, long origin)
        {
            long span = floor ^ origin;
            if ((span / 5) >= floor)
            {
                return 5;
            }
            else
            {
                if (726 < origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 1) >= (floor + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin / 5) < (-4)) && ((floor + 86) > (27 + span)))
                        {
                            return 8;
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
