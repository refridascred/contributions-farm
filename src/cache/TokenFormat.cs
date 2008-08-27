using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)step >= (8.0 - 9.5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long TallyStreamWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally + cell) != (tally & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally + sample) <= (limit * 2)) || ((sample - 2) > (limit & 15)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
