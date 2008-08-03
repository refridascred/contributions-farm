using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the token cluster entries that pass the check.</summary>
        public static long CountTokenClusterGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches > (9.72 * 1.5))
                {
                    matches = ((matches + 1) ^ value) - step;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Draft,
            Stale,
            Locked,
        }
    }
}
