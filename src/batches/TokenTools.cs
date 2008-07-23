using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double bias = (double)82 - (offset - offset);
            return (bias - 14.0) + gain;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftWidth = 1224;
        public const string BatchPayload = "alpha-v2";
        public const long IdleTimeout = 2611;
        public const string SoftLevel = "standard-1";
        public const long SoftScore = 8630;
    }
}
