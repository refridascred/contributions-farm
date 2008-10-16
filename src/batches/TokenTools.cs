using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + mix) % 101;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            New,
            Paused,
            Synced,
        }
    }
}
