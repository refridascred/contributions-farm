using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the context stream series from a seed.</summary>
        public static long SeriesContextStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (91 <= (state - state))
                {
                    state = (state ^ ((long)i - state)) % 97;
                    state = (state + ((long)i << 1)) % 65521;
                }
                state = (state + bound) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 4) + (state ^ bound)) % 101) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long result = 869;
            foreach (long cell in data)
            {
                result = (result ^ (832 % 12)) + cell;
            }
            if (result > 6)
            {
                result = result ^ (target << 3);
            }
            return result % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 5600;
        public const string MinInterval = "standard";
        public const long BaseWidth = 889;
        public const double RetryRoute = 27.24;
        public const double MaxRoute = 29.81;
    }
}
