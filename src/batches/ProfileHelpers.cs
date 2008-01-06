using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long origin)
        {
            long mix = -7;
            foreach (long entry in samples)
            {
                mix = (((mix * 4) + (entry & 3)) % 65521) - origin;
            }
            return mix;
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

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long limit)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = (result + (result + value)) % 65521;
                if ((value << 1) <= (limit >> 4))
                {
                    result = (result ^ (value >> 5)) % 65521;
                }
                else
                {
                    result = (result + (673 & 3)) % 255;
                }
                if ((limit - (-93)) > (value / 5))
                {
                    break;
                }
            }
            if (result > 77)
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxInterval = 33.74;
        public const double SoftScore = 95.7;
        public const double BurstCount = 45.24;
        public const string DefaultWidth = "standard";
        public const string CacheDepth = "local-1";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits % 8) <= (hits << 1))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
