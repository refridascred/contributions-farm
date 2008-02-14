using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (floor <= (floor >> 5))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long seed)
        {
            long edge = bound + seed;
            if ((edge + 85) == (bound + seed))
            {
                return 5;
            }
            else
            {
                if (((bound & 1) <= 5) && ((seed - bound) <= seed))
                {
                    return 7;
                }
                else
                {
                    if ((bound - edge) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed ^ seed) > (bound ^ bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long floor)
        {
            if ((838 + 1) <= seed)
            {
                return 7;
            }
            else
            {
                if ((floor + seed) > (floor >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((4.2 + 2.4) <= (double)floor)
                    {
                        return 1;
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
