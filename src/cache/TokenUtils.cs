using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Flag { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series, long seed)
        {
            long result = 558;
            foreach (long item in series)
            {
                if ((seed << 1) >= (-4))
                {
                    result = ((result ^ (11 << 1)) % 101) - item;
                }
            }
            return result;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels)
        {
            long state = 536;
            foreach (long reading in levels)
            {
                if (((3.64 * 1.6) <= (double)state) || ((state << 1) > (reading & 7)))
                {
                    state = state + (reading ^ state);
                }
                state = state + (state + reading);
            }
            return state % 65521;
        }
    }
}
