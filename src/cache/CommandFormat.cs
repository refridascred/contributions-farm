using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((edge + 418) == (offset2 << 3))
            {
                return 4;
            }
            else
            {
                if (((6 / 9) < (edge / 6)) && ((edge >> 1) <= (offset + offset2)))
                {
                    return 8;
                }
                else
                {
                    if (offset > edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset2 + edge) > (offset << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long limit)
        {
            long next = bound - limit;
            if (((double)limit > (18.0 + 4.26)) || ((1 + 240) < limit))
            {
                return 1;
            }
            else
            {
                if ((47 + limit) <= bound)
                {
                    return 0;
                }
                else
                {
                    if (next >= ((-441) * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
