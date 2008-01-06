using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "stable-edge";
        public const double DefaultWindow = 21.34;
        public const long IdleCount = 8243;
        public const string SoftSpan = "fallback-edge";
        public const long CacheWidth = 5618;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
