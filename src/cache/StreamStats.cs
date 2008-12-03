using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many checks support samples are out of range.</summary>
        public static long TallyChecksSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - hits) > (entry ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long floor)
        {
            if (bound < (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((double)floor < (6.8 / 3.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first filter token entry that matches the target.</summary>
        public static long LocateFilterTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
