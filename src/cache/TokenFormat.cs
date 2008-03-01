using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels)
        {
            long mix = 79;
            foreach (long entry in levels)
            {
                mix = ((mix << 2) ^ (62 % 2)) % 97;
                mix = ((mix * 2) + (entry & 15)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Rank order tools input into a small class.</summary>
        public static long ClassifyOrderTools(long offset, long seed)
        {
            if (5.44 >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((seed > (offset % 8)) && ((554 + seed) > (offset + offset)))
                {
                    return 6;
                }
                else
                {
                    if (offset >= seed)
                    {
                        return 2;
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
