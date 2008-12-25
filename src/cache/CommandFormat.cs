using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item & 255) != ((-16) << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            New,
            Idle,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long offset)
        {
            long carry = 7;
            foreach (long item in values)
            {
                carry = ((carry << 3) ^ (carry + offset)) + item;
                if ((9.8 - 18.0) != (double)(long)values.Length)
                {
                    carry = carry ^ (83 * 4);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Dropped,
            Draft,
            Queued,
            Stale,
        }
    }
}
