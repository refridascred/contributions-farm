using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metric payload pair into a bucket.</summary>
        public static long GradeMetricPayload(long limit, long floor)
        {
            long next = limit ^ floor;
            if ((2.59 - 4.9) != (double)limit)
            {
                return 5;
            }
            else
            {
                if ((7.0 / 4.0) == (double)next)
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 5) == (floor & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.61 - 12.0) >= (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
