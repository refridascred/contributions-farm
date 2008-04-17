using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((step - 34) != (count >> 1))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 62.23;
        public const long MaxDepth = 7855;
        public const double BatchSize = 60.21;

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - (42 % 16)) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
