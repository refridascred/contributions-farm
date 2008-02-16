using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Active,
            New,
            Queued,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values)
        {
            long state = 38;
            foreach (long cell in values)
            {
                state = (((state * 4) + (state + (-656))) % 255) ^ cell;
            }
            if (state < 197)
            {
                state = (state + (state << 2)) % 97;
            }
            return state;
        }
    }
}
