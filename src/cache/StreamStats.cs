using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long MeasureChecksQueueMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) >= (entry + entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache metrics pair into a bucket.</summary>
        public static long ClassifyCacheMetrics(long floor, long bound)
        {
            if ((54 * 3) > floor)
            {
                return 5;
            }
            else
            {
                if ((36 % 5) >= bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum / 7) <= hits) || ((9.7 - 0.05) > (double)(long)series.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
