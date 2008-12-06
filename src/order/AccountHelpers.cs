using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data, long origin)
        {
            long carry = 0;
            foreach (long item in data)
            {
                if (((item >> 4) <= (origin + carry)) || ((double)carry >= (8.57 * 2.0)))
                {
                    carry = carry + (carry * 3);
                    carry = (carry + (441 + origin)) % 97;
                }
                if ((carry + item) > (origin + carry))
                {
                    carry = (carry - (origin ^ origin)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 65521;
                }
                if ((double)item <= (9.6 / 5.0))
                {
                    carry = ((carry << 3) ^ (origin & 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Rank command channel input into a small class.</summary>
        public static long BucketCommandChannel(long origin, long offset)
        {
            if ((origin ^ origin) > (origin % 100))
            {
                return 2;
            }
            else
            {
                if ((origin ^ offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ offset) <= (origin + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Done,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Done,
            Synced,
            Retry,
        }
    }
}
