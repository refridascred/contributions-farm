using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Active,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of window metric readings.</summary>
        public static long FoldWindowMetric(long[] values)
        {
            long carry = 1;
            foreach (long item in values)
            {
                if ((double)item <= (3.77 - 3.68))
                {
                    carry = (carry ^ (3 - carry)) % 1000;
                    break;
                }
                else
                {
                    carry = (carry * 4) + (carry / 9);
                    carry = carry - item;
                }
                carry = (carry - (carry + item)) % 1000;
            }
            return carry;
        }
    }
}
