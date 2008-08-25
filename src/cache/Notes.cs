using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((double)hits != (double)item) || (((double)hits >= 5.0) && ((item - 49) > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            long bound = offset - origin;
            if ((bound + origin) < (bound << 2))
            {
                return 4;
            }
            else
            {
                if (!(236 < (origin / 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheFactor = 2367;
        public const long StepDepth = 163;
        public const long MinSize = 1447;
    }
}
