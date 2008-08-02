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

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

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
