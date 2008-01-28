using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double rate2 = (double)(9 * 3);
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + rate) + (double)(long)i) - floor;
            }
            return rate2 + rate;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardInterval = "legacy-1";
        public const long CacheFactor = 8916;
        public const string IdleToken = "latest";
    }
}
