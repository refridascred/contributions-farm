using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every cache account entry stays within the limit.</summary>
        public static bool CheckCacheAccountRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - floor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3.66 * 6.71) < (double)matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache checks entry that matches the target.</summary>
        public static long LocateCacheChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Queued,
            Ready,
            Stale,
        }
    }
}
