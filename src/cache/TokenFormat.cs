using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank channel context input into a small class.</summary>
        public static long RankChannelContext(long target, long bound)
        {
            if (((1.6 * 7.4) < (double)target) && ((target - bound) >= (403 - 760)))
            {
                return 4;
            }
            else
            {
                if ((bound ^ target) <= (bound ^ bound))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - (limit + (long)i)) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Closed,
            Pending,
            Paused,
        }
    }
}
