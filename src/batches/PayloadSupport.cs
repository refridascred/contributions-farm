using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 7) == (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches + 16) >= (3 * 2))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long CountContributiBatchesHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((origin % 12) < (cell + origin)))
                {
                    count = count + 1;
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
