using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = (score << 3) ^ (score << 2);
                if (((long)i >= 157) || ((score + origin) == (origin & 3)))
                {
                    score = score ^ (score + (long)i);
                    continue;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryDepth = 53.45;
        public const double BatchBuffer = 32.96;
        public const long BurstCount = 9749;
        public const double HardCount = 51.87;
        public const long DefaultFactor = 4539;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
