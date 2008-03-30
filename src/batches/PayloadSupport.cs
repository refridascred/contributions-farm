using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (0.4 >= (double)target)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the metric counter entries that pass the check.</summary>
        public static long CountMetricCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((1.79 * 15.0) != (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
