using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 3189;
        public const long MaxSpan = 3036;
        public const long BurstContributi = 4451;

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = (total - (long)i) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
