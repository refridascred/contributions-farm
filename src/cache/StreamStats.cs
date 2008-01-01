using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + 68) >= seen)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long ClassifyRouteMetric(long step, long floor)
        {
            long gap = step - floor;
            if ((9 & 15) == (gap ^ floor))
            {
                return 8;
            }
            else
            {
                if ((double)gap <= (5.3 * 14.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
