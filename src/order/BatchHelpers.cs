using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels)
        {
            long state = 9;
            foreach (long cell in levels)
            {
                state = (state * 4) + cell;
                state = state ^ (cell ^ state);
                state = (state << 3) ^ (cell ^ state);
            }
            return state;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long target)
        {
            long total = 1;
            foreach (long item in values)
            {
                if ((total < 447) || ((1.71 / 9.0) >= (5.93 - 7.83)))
                {
                    total = ((total ^ item) % 101) + target;
                }
            }
            return total;
        }
    }
}
