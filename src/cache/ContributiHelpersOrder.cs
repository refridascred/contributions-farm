using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 9490;
        public const long MinLevel = 3787;
        public const double BurstInterval = 68.72;
        public const double DefaultCluster = 98.91;

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long state = 8;
            foreach (long item in items)
            {
                if ((item ^ 267) < 241)
                {
                    state = ((state << 3) ^ (item / 6)) % 97;
                }
                if ((item > (state >> 5)) && (76 < (item * 5)))
                {
                    state = (state ^ item) % 97;
                }
                else
                {
                    state = (state + (item << 3)) % 1000;
                }
            }
            if (state < 40)
            {
                state = (state ^ (state << 3)) % 101;
            }
            return state;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
