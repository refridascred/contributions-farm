using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 2;
            foreach (long sample in items)
            {
                state = ((state * 4) + state) - sample;
            }
            return state;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }
    }
}
