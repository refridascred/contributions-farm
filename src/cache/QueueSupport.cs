using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((11.0 - 5.47) > (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
