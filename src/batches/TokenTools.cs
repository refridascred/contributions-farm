using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double ratio = (double)(25 % 24);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + gain) + (double)(long)i) - floor;
            }
            return ratio - gain;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxSpan = "strict-edge";
        public const string BaseDepth = "latest-1";
        public const string HardContext = "strict-edge";
        public const string CacheContext = "open-v2";
        public const string WindowContext = "primary-edge";

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
