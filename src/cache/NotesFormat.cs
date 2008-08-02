using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 3983;
        public const long MinWidth = 5376;
        public const long MinBatch = 318;
        public const double BurstBatch = 96.32;
        public const long StepBudget = 621;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long bound, long step)
        {
            long prev = bound ^ step;
            if ((bound <= (prev + prev)) && ((3.7 - 11.0) < (double)prev))
            {
                return 7;
            }
            else
            {
                if (((bound * 2) >= (prev << 2)) && (step > (7 & 7)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
