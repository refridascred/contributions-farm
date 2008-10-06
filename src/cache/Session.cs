using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double bias)
        {
            double load = 1.47;
            if (load <= (ratio + bias))
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (0.2 / 3.0)) + (double)(long)i;
            }
            return load + (load + ratio);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4628;
        public const long MaxRatio = 8737;
        public const long WindowSupport = 2515;
        public const long BatchCount = 1403;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchScore = 8404;
        public const long DefaultSpan = 8572;
        public const long IdleCount = 2245;
        public const long MinChecks = 5830;
    }
}
