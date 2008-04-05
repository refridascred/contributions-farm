using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next commits token value from a seed.</summary>
        public static long IterateCommitsToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state * 4) + (seed >> 3);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Locked,
            Dropped,
            Pending,
            Stale,
        }
    }
}
