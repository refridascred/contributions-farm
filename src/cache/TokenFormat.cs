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

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Draft,
            Stale,
            Queued,
            Dropped,
        }
    }
}
