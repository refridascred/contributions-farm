using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Closed,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((35 + bound) > (bound >> 2))
            {
                return 4;
            }
            else
            {
                if ((bound + offset) > (882 - offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset > (bound + bound)) && ((double)offset < (1.0 - 0.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values, long offset)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if ((88 > entry) && ((double)carry < 9.7))
                {
                    carry = (carry << 3) ^ carry;
                    carry = (carry * 3) + (entry * 3);
                }
                carry = (carry ^ ((long)values.Length + entry)) % 97;
                if ((double)offset > (double)carry)
                {
                    carry = ((carry << 2) ^ 4) % 4096;
                }
                if ((double)entry == (0.3 + 6.0))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
