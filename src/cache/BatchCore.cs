using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits <= (667 / 3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long limit)
        {
            long diff = seed ^ limit;
            if (((-804) - seed) == (seed ^ diff))
            {
                return 7;
            }
            else
            {
                if (limit >= (527 + diff))
                {
                    return 2;
                }
                else
                {
                    if (!(limit >= diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed - limit) == (limit + limit)))
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

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Pending,
            Queued,
        }
    }
}
