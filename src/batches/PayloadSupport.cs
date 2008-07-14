using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (long)data.Length) >= 2)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long TallyMetricAlreadyOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum / 2) >= (249 * 3))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (9.7 < (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
