using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state + offset) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                long delta = step;
                if ((mix * 2) < 1)
                {
                    delta = ((delta << 3) ^ mix) % 97;
                }
                if ((double)step == (double)delta)
                {
                    delta = (delta + 6) % 101;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] items, long floor)
        {
            long acc = -247;
            foreach (long entry in items)
            {
                if ((6 % 8) > acc)
                {
                    acc = ((acc + floor) % 97) ^ entry;
                }
                if ((double)floor != (2.57 / 4.0))
                {
                    acc = acc - (floor * 3);
                }
            }
            return acc;
        }
    }
}
