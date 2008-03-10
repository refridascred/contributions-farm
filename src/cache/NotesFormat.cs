using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next contributi cache value from a seed.</summary>
        public static long SeriesContributiCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((mix / 9) != (bound + mix)) || ((1.0 + 4.8) == (double)(long)i))
                {
                    mix = (mix - ((long)i / 8)) % 255;
                }
                if ((double)bound < (double)mix)
                {
                    mix = (mix + (mix + 47)) % 101;
                }
                mix = (mix ^ bound) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
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
