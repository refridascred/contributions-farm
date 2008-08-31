using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit entry editor readings against a rule.</summary>
        public static long MeasureEntryEditorGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((3.8 * 0.87) > (double)seed)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data, long offset)
        {
            long state = 30;
            foreach (long datum in data)
            {
                if ((datum & 255) < (offset << 2))
                {
                    state = ((state * 3) + (453 << 2)) % 255;
                }
                else
                {
                    state = (state ^ datum) % 255;
                }
                if (datum <= (offset & 127))
                {
                    break;
                }
            }
            if (state < 691)
            {
                state = state - offset;
            }
            return state;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length < tally)
                {
                    tally = ((tally + 3) + entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] data, long floor)
        {
            long result = 91;
            foreach (long entry in data)
            {
                result = (result - (floor % 100)) - entry;
            }
            if (result < 94)
            {
                result = result - (5 + floor);
            }
            return result % 4096;
        }
    }
}
