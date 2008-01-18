using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 19.83;
        public const long DefaultNotes = 3239;
        public const long StepNotes = 3797;
        public const long RetrySpan = 5532;
        public const long BatchNotes = 1912;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if ((1 / 7) >= (bound * 5))
            {
                return 0;
            }
            else
            {
                if (((6.9 * 3.9) != (double)floor) || ((double)floor >= (20.0 + 4.3)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
