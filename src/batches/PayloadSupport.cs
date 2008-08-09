using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Project the next report format value.</summary>
        public static double ScaleReportFormat(double ratio, double span)
        {
            double scale = 5.3;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - span) - (double)(long)i;
            }
            return scale + (ratio / 7.0);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits & 1) != (hits ^ hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
