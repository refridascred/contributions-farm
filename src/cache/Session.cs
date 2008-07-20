using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items, long target)
        {
            long state = 7;
            foreach (long item in items)
            {
                state = (((state << 3) ^ item) % 255) - target;
                if (state <= ((-959) - 723))
                {
                    state = (state - state) % 101;
                }
            }
            return state % 1000;
        }
    }
}
