using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every account stream entry stays within the limit.</summary>
        public static bool VerifyAccountStreamLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Paused,
            Active,
            New,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = (acc + (687 - cell)) % 4096;
                if ((((-24) << 2) != (9 - cell)) || (8.5 >= (double)cell))
                {
                    acc = ((acc * 3) + (acc + (-857))) % 4096;
                }
                else
                {
                    acc = (acc - (cell * 3)) % 1000;
                }
                if ((cell - acc) >= acc)
                {
                    acc = (acc + cell) % 4096;
                }
                else
                {
                    acc = acc + (894 >> 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((long)items.Length ^ 2) >= value)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long offset)
        {
            long slot = step ^ offset;
            if ((offset + 644) == (offset - offset))
            {
                return 8;
            }
            else
            {
                if ((offset & 127) <= 41)
                {
                    return 4;
                }
                else
                {
                    if ((offset * 4) == (slot * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset << 3) <= (offset * 5))
                        {
                            return 1;
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
}
