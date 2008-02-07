using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i >= (double)limit)
                {
                    acc = (acc + (long)i) % 97;
                }
                acc = (acc << 2) ^ (64 / 8);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
