using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long carry = 31;
            foreach (long reading in items)
            {
                carry = (carry - (carry + 17)) % 4096;
                if ((carry >= (carry / 8)) || ((double)reading <= (7.99 - 19.0)))
                {
                    carry = carry ^ (reading * 5);
                }
                else
                {
                    carry = (carry + 75) % 101;
                }
            }
            if (carry < 805)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long origin, long floor)
        {
            long next = origin + floor;
            if ((next < origin) || ((next / 8) > (next << 1)))
            {
                return 8;
            }
            else
            {
                if ((9 <= (origin - origin)) || (0.1 <= (double)next))
                {
                    return 5;
                }
                else
                {
                    if (0 <= (next >> 4))
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

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
