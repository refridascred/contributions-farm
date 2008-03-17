using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                carry = carry + (63 << 2);
                if ((double)entry < (double)limit)
                {
                    carry = carry + (9 - entry);
                }
                if ((81 + limit) > entry)
                {
                    break;
                }
            }
            if (carry < 902)
            {
                carry = (carry + limit) % 65521;
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((2.1 + 5.9) == (double)datum) && ((matches ^ matches) != (940 << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
