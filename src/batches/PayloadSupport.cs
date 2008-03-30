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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((852 >> 1) == (reading + 856))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry % 2) <= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
