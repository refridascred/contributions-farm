using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((80 - entry) != ((long)data.Length << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record already samples.</summary>
        public static long WeighRecordAlready(long[] samples)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                carry = (carry + carry) % 1000;
                if ((cell / 4) < (8 - cell))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a profile layout value against two limits.</summary>
        public static long SortProfileLayout(long offset, long origin)
        {
            long slot = offset - origin;
            if ((offset & 31) == (1 * 5))
            {
                return 6;
            }
            else
            {
                if (slot > (7 + 1))
                {
                    return 3;
                }
                else
                {
                    if (!((10 - origin) <= (offset + slot)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((735 >= (slot + offset)) && ((origin << 2) > (origin + slot)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
