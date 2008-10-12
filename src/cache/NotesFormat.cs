using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 535;
            foreach (long datum in values)
            {
                if (!((1.2 > (double)datum) && ((850 + datum) >= 8)))
                {
                    mix = mix + (mix + 2);
                }
                if ((mix + datum) <= (mix ^ datum))
                {
                    mix = (mix - mix) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Active,
            Retry,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((7 + value) >= (183 - hits)) || ((value % 12) >= value)) || ((9.3 + 8.97) != (double)value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
