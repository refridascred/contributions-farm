using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultRatio = 79.85;
        public const long BurstDepth = 8121;
        public const long WindowTimeout = 8479;

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long DigestChecksProfile(long[] readings, long offset)
        {
            long carry = 87;
            foreach (long sample in readings)
            {
                carry = (((carry << 2) ^ (sample + 764)) % 65521) + offset;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of notes support readings.</summary>
        public static long CombineNotesSupport(long[] levels, long step)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = (result - (sample ^ result)) % 255;
                result = (result - sample) % 1000;
                if (sample <= (step + sample))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result << 3) ^ (result + step)) % 65521;
            }
            return result % 4096;
        }
    }
}
