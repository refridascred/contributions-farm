using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches % 5) <= matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((-4) > (hits - 0)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long offset, long limit)
        {
            if (offset > (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((limit / 7) >= (limit & 127))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
