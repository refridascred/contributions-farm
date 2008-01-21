using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long step)
        {
            long mix = 657;
            foreach (long reading in levels)
            {
                if ((long)levels.Length < 445)
                {
                    mix = ((mix * 2) + (step + reading)) % 97;
                }
                else
                {
                    mix = (mix ^ step) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            New,
            Draft,
            Idle,
        }
    }
}
