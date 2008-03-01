using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry ^ hits) != (hits + (-8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)bound < (3.05 * 17.0))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
