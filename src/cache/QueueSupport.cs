using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a filter queue counter forward.</summary>
        public static long DeriveFilterQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long state = 5;
            foreach (long cell in items)
            {
                if (state >= (state + state))
                {
                    state = state ^ (3 << 3);
                }
                else
                {
                    state = ((state << 3) ^ (cell + state)) % 4096;
                }
                if ((cell + offset) >= (long)items.Length)
                {
                    state = (state << 3) ^ (cell - 69);
                }
            }
            return state;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = -355;
            foreach (long item in items)
            {
                if ((double)anchor < 4.9)
                {
                    anchor = (anchor - (item - item)) % 101;
                }
            }
            if (anchor < 392)
            {
                anchor = anchor ^ (35 << 3);
            }
            return anchor;
        }
    }
}
