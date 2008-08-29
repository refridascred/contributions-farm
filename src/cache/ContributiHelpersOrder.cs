using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data)
        {
            long carry = -5;
            foreach (long cell in data)
            {
                if ((double)cell < 7.87)
                {
                    carry = (carry << 3) ^ (carry & 7);
                    carry = carry ^ (carry + carry);
                }
                carry = ((carry << 3) ^ (carry % 8)) % 97;
            }
            if (carry > 376)
            {
                carry = (carry + (carry - carry)) % 101;
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
