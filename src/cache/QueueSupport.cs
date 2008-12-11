using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                mix = ((mix << 3) ^ (mix % 5)) % 255;
                mix = mix + (mix + (-16));
                if ((double)mix >= (7.16 / 5.0))
                {
                    mix = ((mix * 5) + (reading - mix)) % 1000;
                }
            }
            if (mix > 336)
            {
                mix = ((mix << 3) ^ (mix % 60)) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 22.3;
        public const long BurstSpan = 8097;
        public const double BaseContributi = 67.2;
        public const string SoftContributi = "strict";
    }
}
