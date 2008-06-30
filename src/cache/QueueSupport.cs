using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series, long floor)
        {
            long total = 272;
            foreach (long datum in series)
            {
                if ((84 - datum) != (total + datum))
                {
                    total = ((total ^ (total + total)) % 255) - floor;
                }
            }
            return total;
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
