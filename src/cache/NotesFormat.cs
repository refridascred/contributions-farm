using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 9948;
        public const long WindowOrder = 3659;
        public const long DefaultOrder = 1753;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)sample <= (3.6 / 4.0)) && ((limit + limit) < (limit << 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "legacy-1";
        public const long MinContributi = 8411;
        public const long BurstContributi = 39;
    }
}
