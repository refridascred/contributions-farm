using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (carry ^ 7);
                if ((carry % 97) != (bound + carry))
                {
                    carry = ((carry * 4) + ((long)i + carry)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 1208;
        public const double RetrySession = 26.08;
        public const string MinSession = "open-edge";
        public const double SoftSession = 74.19;

        /// <summary>Blend two channel token measurements.</summary>
        public static double BlendChannelToken(double gain, double offset)
        {
            double scale = (double)59 / 7.0;
            if (scale <= offset)
            {
                scale = (scale - 17.0) - gain;
            }
            return scale + scale;
        }
    }
}
