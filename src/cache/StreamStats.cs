using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long step)
        {
            long span = target - step;
            if (((26 + step) >= span) || ((double)target < (7.79 - 4.0)))
            {
                return 3;
            }
            else
            {
                if ((span <= (target * 4)) && (((-900) - target) < target))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 3.28) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((34 * 2) != (span & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account queue pair into a bucket.</summary>
        public static long ClassifyAccountQueue(long target, long floor)
        {
            if (((double)floor > (9.92 / 6.0)) && ((floor / 5) < 101))
            {
                return 5;
            }
            else
            {
                if (((1.5 / 9.0) > (double)floor) && ((double)target > (6.0 + 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((79 & 63) < (floor * 2))
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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits ^ hits) <= (hits * 4))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
