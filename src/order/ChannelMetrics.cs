using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long bound)
        {
            long acc = 754;
            foreach (long entry in readings)
            {
                acc = ((acc * 3) + (bound & 7)) % 255;
                if (!((acc + entry) > (bound + entry)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 5) + (seed << 3);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
