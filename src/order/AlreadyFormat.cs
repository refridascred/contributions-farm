using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long TallyGraphRouteMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 9.3)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((entry << 3) >= (count + count)) || ((count << 1) <= entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TallyNotesSchema(long[] values)
        {
            long mark = 843;
            foreach (long value in values)
            {
                mark = ((mark - (86 + mark)) % 101) ^ value;
                if (!((mark ^ mark) < (79 * 5)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
