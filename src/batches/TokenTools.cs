using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Done,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long floor, long bound)
        {
            long slot = floor ^ bound;
            if ((bound * 5) <= (416 + slot))
            {
                return 4;
            }
            else
            {
                if ((slot + floor) >= slot)
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 2) <= (-313))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor + bound) > (slot - slot)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
