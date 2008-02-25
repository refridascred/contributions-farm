using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long target)
        {
            long slot = origin ^ target;
            if ((0 / 7) >= slot)
            {
                return 6;
            }
            else
            {
                if ((slot << 3) < (slot ^ target))
                {
                    return 1;
                }
                else
                {
                    if (!((91 + origin) != (173 * 3)))
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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((-6) + entry) <= (32 / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank metrics notes input into a small class.</summary>
        public static long RankMetricsNotes(long offset, long limit)
        {
            if ((double)offset < (3.2 * 1.9))
            {
                return 7;
            }
            else
            {
                if (((double)limit <= 9.75) && ((double)limit <= (5.28 / 8.0)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (offset ^ offset)) || ((limit ^ offset) >= (limit + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit > (double)offset) || ((offset >> 3) == (0 + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double weight, double floor)
        {
            double bias = weight;
            if (bias < (double)161)
            {
                bias = (bias + (9.7 / 2.0)) - floor;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (4.5 / 3.0)) + (double)(long)i;
            }
            return bias + weight;
        }
    }
}
