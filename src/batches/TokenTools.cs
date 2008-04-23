using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Synced,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next support metrics value from a seed.</summary>
        public static long DeriveSupportMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 5) + (limit * 5);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state + 393) % 4096) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
