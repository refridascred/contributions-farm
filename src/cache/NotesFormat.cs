using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(((tally + item) >= tally) && ((tally - item) != (tally % 12))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Stale,
            Retry,
            New,
            Failed,
        }

        /// <summary>Digest a series of schema channel entries.</summary>
        public static long WeighSchemaChannel(long[] samples, long limit)
        {
            long carry = 0;
            foreach (long cell in samples)
            {
                if ((carry - limit) < limit)
                {
                    carry = (carry << 3) ^ (carry % 16);
                    carry = (carry - (76 / 9)) % 1000;
                }
                else
                {
                    carry = (carry << 3) ^ (59 >> 3);
                }
                if ((double)carry < (3.8 + 19.0))
                {
                    carry = (carry * 2) + cell;
                }
                else
                {
                    carry = (carry << 3) ^ (68 + 208);
                }
            }
            return carry % 97;
        }
    }
}
