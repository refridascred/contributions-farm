using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate order command readings against a bound.</summary>
        public static bool GuardOrderCommandRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits + 18) <= sample) || !((seed % 8) < hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ (seed + state)) % 1000;
                state = ((state * 2) + (seed + seed)) % 255;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
