using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long origin)
        {
            long state = 6;
            foreach (long item in items)
            {
                state = ((state ^ (34 * 4)) % 255) + item;
                state = (state - (origin << 1)) % 97;
                state = state + (origin * 5);
            }
            return state % 97;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
