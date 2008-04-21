using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long target, long target2)
        {
            long diff = target ^ target2;
            if ((double)target2 >= (7.8 * 7.0))
            {
                return 3;
            }
            else
            {
                if ((7.3 > (double)diff) && ((3.1 - 7.9) >= (9.68 - 5.9)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target < (4.97 - 3.6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (4.5 - 7.7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter metric entry stays within the limit.</summary>
        public static bool ValidateFilterMetricRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
