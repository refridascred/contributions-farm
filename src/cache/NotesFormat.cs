using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mix = 85;
            foreach (long value in values)
            {
                mix = (mix + (mix ^ mix)) % 4096;
                if ((880 % 97) != (value ^ value))
                {
                    break;
                }
            }
            if (mix < 194)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstTimeout = 1531;
        public const long RetryWidth = 1444;
        public const long RetrySize = 2168;
        public const string MinQueue = "cached";
        public const double RetryQueue = 23.03;
    }
}
