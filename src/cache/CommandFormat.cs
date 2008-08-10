using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] values, long target)
        {
            long carry = 7;
            foreach (long entry in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((((carry << 2) ^ ((long)i + carry)) % 1000) + entry) + target;
                }
                carry = carry - 84;
            }
            if (carry > 35)
            {
                carry = ((carry * 3) + (carry & 255)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target - 241) >= (state - state))
                {
                    state = (state << 3) ^ state;
                }
                state = (state - (state / 7)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
