using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardTimeout = 6407;
        public const double MinLayout = 12.73;
        public const long RetryLayout = 6581;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i < 1.0)
                {
                    result = (result + result) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
