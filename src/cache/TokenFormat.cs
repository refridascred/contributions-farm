using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Synced,
            Closed,
            Done,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if ((8.0 + 3.94) < (double)state)
                {
                    state = (state * 5) + target;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
