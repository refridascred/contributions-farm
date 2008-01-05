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

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long TallyFarmBufferHits(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((step + count) >= ((long)series.Length + 480))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
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
