using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry cache samples are out of range.</summary>
        public static long AuditEntryCacheMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen > (19.0 * 3.6))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item / 2) > (835 - tally))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
