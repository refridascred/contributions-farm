using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxScore = 6960;
        public const long BurstTimeout = 4265;
        public const long MinRatio = 9862;

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
