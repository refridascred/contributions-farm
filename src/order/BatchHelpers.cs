using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double drift = (double)(867 / 4);
            if (drift <= (gain - drift))
            {
                drift = (drift + drift) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 3.0) + (double)(long)i;
            }
            return drift - 9.7;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 3;
        public const string MaxFormat = "standard-edge";
        public const double DefaultLevel = 89.22;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
