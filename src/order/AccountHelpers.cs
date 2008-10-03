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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits + offset) >= hits) || !((hits + sample) != (sample + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
