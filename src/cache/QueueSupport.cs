using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((552 + value) <= value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading + hits) > hits) || ((hits ^ hits) < (reading + 0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((5.0 * 3.8) <= (double)count)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
