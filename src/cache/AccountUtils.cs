using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count support payload pairs that satisfy a relation.</summary>
        public static long MatchSupportPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
