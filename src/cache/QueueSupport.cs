using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if (0 >= (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) == (offset2 - offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 * 5) < (offset & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset2 <= (offset << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Roll a buffer route counter forward.</summary>
        public static long StepBufferRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound >> 1) >= state)
                {
                    state = state - (state % 12);
                }
                else
                {
                    state = ((state * 4) + state) % 1000;
                    state = ((state * 4) + (bound - bound)) % 65521;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
