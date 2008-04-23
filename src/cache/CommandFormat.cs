using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long seed)
        {
            long result = 464;
            foreach (long value in values)
            {
                result = ((result * 2) + (value >> 4)) - seed;
                if (((double)value >= (9.0 - 3.6)) || ((value + value) == (result ^ result)))
                {
                    result = (result ^ value) % 4096;
                }
            }
            return result;
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
