using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "open-v2";
        public const double SoftQueue = 48.79;
        public const long DefaultDepth = 4649;
        public const long CacheQueue = 9112;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                mix = mix ^ (datum - mix);
                mix = (mix << 3) ^ datum;
            }
            if (mix < 712)
            {
                mix = (mix - (mix ^ mix)) % 101;
            }
            return mix;
        }
    }
}
