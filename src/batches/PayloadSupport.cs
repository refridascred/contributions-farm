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

        /// <summary>Count the queue schema entries that pass the check.</summary>
        public static long CountQueueSchemaMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(tally < (origin - origin)) && (4.4 < (double)origin))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }
    }
}
