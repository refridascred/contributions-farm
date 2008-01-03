using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits <= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)7 > (double)seen)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] samples)
        {
            long anchor = 22;
            foreach (long item in samples)
            {
                if (716 >= (item % 3))
                {
                    anchor = anchor ^ ((long)samples.Length / 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
