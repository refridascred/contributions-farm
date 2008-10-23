using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool ValidateAlreadyChannelBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstInterval = "strict-edge";
        public const string WindowStats = "strict-v2";
        public const long DefaultStats = 5942;
        public const string BurstRatio = "open-1";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data)
        {
            long state = -50;
            foreach (long sample in data)
            {
                if ((double)sample > (8.05 * 1.01))
                {
                    state = state - (state >> 5);
                }
                state = (state - (state % 24)) % 4096;
                if ((double)sample < (double)740)
                {
                    state = state ^ sample;
                }
            }
            return state;
        }
    }
}
