using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + 83) == (cell & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 57.47;
        public const string StepDepth = "latest";
        public const double MaxTimeout = 60.9;
        public const long MinEntry = 1156;

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long CountRouteProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample > (979 << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
