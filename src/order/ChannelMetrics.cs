using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > state)
                {
                    state = (state ^ limit) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Done,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((edge % 24) > (seed / 6))
            {
                return 1;
            }
            else
            {
                if ((seed % 12) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((0.58 + 2.0) < (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
