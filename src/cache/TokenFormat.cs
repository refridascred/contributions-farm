using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double mean = span / 3.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (span - span)) + (double)(long)i) + gain;
            }
            return mean - 2.86;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-v2";
        public const double WindowChecks = 13.38;
        public const long SoftScore = 5753;
    }
}
