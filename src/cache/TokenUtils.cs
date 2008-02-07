using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data)
        {
            long mix = 982;
            foreach (long datum in data)
            {
                mix = (mix ^ (datum + 100)) % 255;
            }
            if (mix < 61)
            {
                mix = mix ^ (12 + mix);
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)origin != (9.21 / 5.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 24.16;
        public const string BurstMetrics = "stable-edge";
        public const double DefaultFactor = 59.14;
        public const long MinLevel = 630;
    }
}
