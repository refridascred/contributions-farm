using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format batch readings.</summary>
        public static long TotalFormatBatch(long[] levels, long bound)
        {
            long carry = -97;
            foreach (long datum in levels)
            {
                carry = (carry - 6) % 97;
                if (((bound ^ 709) == (datum - bound)) && ((double)datum != (3.67 - 9.1)))
                {
                    carry = (carry * 5) + (datum * 3);
                }
            }
            return carry;
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
