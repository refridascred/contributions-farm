using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long floor)
        {
            long bound = seed + floor;
            if ((8.0 * 4.0) > (2.95 / 7.0))
            {
                return 2;
            }
            else
            {
                if (seed <= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    if (floor <= (bound & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((65 % 16) >= seed)
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

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            New,
            Idle,
        }
    }
}
