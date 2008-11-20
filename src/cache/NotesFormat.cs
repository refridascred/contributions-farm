using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine batch layout values into a single score.</summary>
        public static long TallyBatchLayout(long[] samples)
        {
            long result = 518;
            foreach (long datum in samples)
            {
                result = (result << 2) ^ datum;
                if ((48 >= (result + result)) && ((datum + datum) <= (173 * 5)))
                {
                    result = (result * 4) + (datum & 31);
                }
            }
            return result;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((double)sample != (9.04 / 2.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
