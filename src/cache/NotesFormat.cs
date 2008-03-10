using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter checks readings.</summary>
        public static long TotalFilterChecks(long[] items, long target)
        {
            long acc = 673;
            foreach (long cell in items)
            {
                acc = (acc + acc) % 65521;
                if ((cell <= (cell << 1)) || ((target & 127) >= (acc * 2)))
                {
                    acc = ((acc << 2) ^ (cell >> 2)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long origin)
        {
            if ((bound / 9) == (origin << 2))
            {
                return 2;
            }
            else
            {
                if ((2.38 / 2.0) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin / 6) == (86 + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound) <= origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
