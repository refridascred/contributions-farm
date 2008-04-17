using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultScore = 8466;
        public const long CacheTimeout = 8899;
        public const long MinAlready = 6320;
        public const long WindowAlready = 6150;
        public const long BatchAlready = 2503;

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
