using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits >> 1) >= (entry << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi metric counter forward.</summary>
        public static long SeriesContributiMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((686 - result) >= (result / 6))
                {
                    result = ((result * 3) + ((long)i << 3)) % 255;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 63) < (reading + 71))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
