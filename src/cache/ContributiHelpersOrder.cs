using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long origin, long target)
        {
            if (((double)target > (3.6 / 5.0)) || ((8 >> 3) <= (target & 63)))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= 19.0)
                {
                    return 2;
                }
                else
                {
                    if ((5.41 + 9.2) > (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 6) != (target % 12))
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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= 9.0)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
