using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings, long bound)
        {
            long mix = 315;
            foreach (long value in readings)
            {
                mix = (mix ^ (bound >> 3)) % 101;
                mix = mix + (2 + value);
            }
            if (mix < 4)
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 65521;
        }

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

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long offset)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                acc = ((acc - (2 / 4)) - value) - offset;
            }
            if (acc < 49)
            {
                acc = (acc * 4) + (acc % 97);
            }
            return acc;
        }
    }
}
