using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) == (hits >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - hits) == (hits + datum))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Project the next counter session value.</summary>
        public static double BlendCounterSession(double scale, double span)
        {
            double drift = (2.43 * 1.19) + scale;
            if (drift <= (double)9)
            {
                drift = (drift - (double)805) - span;
            }
            return drift - 4.31;
        }
    }
}
