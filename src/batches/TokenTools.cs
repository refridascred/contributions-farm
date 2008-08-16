using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Failed,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long floor)
        {
            long sum = 704;
            foreach (long cell in levels)
            {
                sum = (((sum * 2) + ((-65) ^ cell)) % 4096) + floor;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values, long floor)
        {
            long state = 12;
            foreach (long item in values)
            {
                state = ((state * 5) + (item ^ item)) % 97;
                if ((floor ^ item) <= (item + item))
                {
                    state = (state ^ state) % 101;
                    state = ((state * 2) + state) % 65521;
                }
                if (((item & 15) > (item >> 5)) || ((4.65 / 3.0) <= (double)state))
                {
                    state = state + (floor << 1);
                }
            }
            return state % 97;
        }
    }
}
