using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine graph batches values into a single score.</summary>
        public static long FoldGraphBatches(long[] data, long floor)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if (((entry << 1) <= (mark & 15)) || ((3 + floor) < floor))
                {
                    mark = (mark - (mark % 8)) % 1000;
                }
            }
            if (mark < 36)
            {
                mark = ((mark << 3) ^ floor) % 255;
            }
            return mark;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 42.95;
        public const double BaseSpan = 3.68;
        public const double DefaultScore = 59.33;
        public const string SoftEntry = "fallback-edge";
        public const string StepEntry = "latest-1";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
