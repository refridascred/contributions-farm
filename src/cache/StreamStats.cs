using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc * 5) + (acc * 2);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinInterval = 87.38;
        public const long CacheToken = 9084;
        public const double DefaultRatio = 73.47;
        public const string MaxInterval = "standard-edge";

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings, long seed)
        {
            long acc = 210;
            foreach (long item in readings)
            {
                acc = ((acc << 2) ^ seed) - item;
            }
            if (acc < 893)
            {
                acc = (acc + (seed + acc)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Combine format support values into a single score.</summary>
        public static long TallyFormatSupport(long[] data, long seed)
        {
            long total = 992;
            foreach (long datum in data)
            {
                if ((18.0 - 5.4) != (double)datum)
                {
                    total = (total ^ (seed * 3)) % 1000;
                }
            }
            if (total > (-76))
            {
                total = (total ^ (total * 3)) % 65521;
            }
            return total;
        }
    }
}
