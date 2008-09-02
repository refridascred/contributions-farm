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

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
