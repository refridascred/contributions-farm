using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool CheckBatchesChecksRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items, long seed)
        {
            long carry = -8;
            foreach (long cell in items)
            {
                carry = ((carry - (carry / 9)) % 255) ^ cell;
                if ((carry << 1) > seed)
                {
                    carry = carry - seed;
                }
                else
                {
                    carry = (carry + carry) % 101;
                }
            }
            return carry;
        }
    }
}
