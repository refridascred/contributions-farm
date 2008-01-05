using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Queued,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long RankCommitsMetric(long limit, long floor)
        {
            long delta = limit + floor;
            if ((double)limit == (6.8 - 9.0))
            {
                return 0;
            }
            else
            {
                if ((floor + 279) > delta)
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 4) >= (15 & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)delta > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long floor, long target)
        {
            if (!((846 + floor) != (floor - floor)))
            {
                return 7;
            }
            else
            {
                if (target >= ((-703) & 255))
                {
                    return 3;
                }
                else
                {
                    if (target <= (63 << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target + 99) > (floor + 473)) || ((floor >> 2) < floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)entry != (6.4 - 13.0)) && (((entry + 23) >= (entry - hits)) || ((8 & 3) < (hits / 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
