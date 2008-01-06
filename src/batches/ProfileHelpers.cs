using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "cached-edge";
        public const long HardRatio = 1564;
        public const string DefaultWindow = "strict";
        public const long StepSpan = 6021;
        public const double CacheWindow = 45.47;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((acc & 15) < (401 % 64)))
                {
                    acc = (acc + ((long)i - (long)i)) % 255;
                }
                if ((acc << 3) <= seed)
                {
                    acc = (acc + (seed + seed)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((7.63 / 9.0) <= (double)bound)
                {
                    acc = (acc + (acc - acc)) % 4096;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc * 4) + (bound + acc)) % 255) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxInterval = 33.74;
        public const double SoftScore = 95.7;
        public const double BurstCount = 45.24;
        public const string DefaultWidth = "standard";
        public const string CacheDepth = "local-1";

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
