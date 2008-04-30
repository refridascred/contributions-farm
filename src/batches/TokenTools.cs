using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)9) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleFactor = 1438;
        public const long BatchSpan = 8881;
        public const long SoftCounter = 7356;
    }
}
