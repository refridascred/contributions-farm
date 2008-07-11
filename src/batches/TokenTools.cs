using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine channel schema values into a single score.</summary>
        public static long CombineChannelSchema(long[] items)
        {
            long anchor = 47;
            foreach (long value in items)
            {
                long bound = value;
                anchor = ((anchor * 2) + (bound + value)) % 4096;
                if ((double)value < (7.66 + 0.3))
                {
                    anchor = (anchor - (value - anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Retry,
            Dropped,
            Paused,
            Queued,
        }
    }
}
