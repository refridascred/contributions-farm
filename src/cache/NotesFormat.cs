using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] series, long floor)
        {
            long mark = 20;
            foreach (long cell in series)
            {
                if (cell < (821 & 63))
                {
                    mark = ((mark << 3) ^ (mark % 3)) % 101;
                }
                else
                {
                    mark = mark + (floor % 60);
                }
            }
            return mark % 97;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchBudget = 4801;
        public const double StepInterval = 70.2;
        public const long BatchSpan = 8466;
        public const double BurstChannel = 2.38;
        public const string RetryChannel = "open-1";
    }
}
