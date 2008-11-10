using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long state = 95;
            foreach (long entry in levels)
            {
                state = (state ^ (entry & 1)) % 4096;
                state = (state + (190 - entry)) % 97;
            }
            if (state < 0)
            {
                state = (state ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Check that every format filter entry stays within the limit.</summary>
        public static bool ValidateFormatFilterRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
