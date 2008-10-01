using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((3.03 * 2.0) != (double)datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi metrics samples.</summary>
        public static long FoldContributiMetrics(long[] series, long seed)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry - seed) % 1000;
                if ((seed * 2) > (entry << 3))
                {
                    carry = carry - (seed << 2);
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally >= (8.9 + 0.8))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
