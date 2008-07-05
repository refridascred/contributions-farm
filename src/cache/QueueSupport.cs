using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleCount = 14.25;
        public const long SoftInterval = 8711;
        public const string LimitEditor = "primary-v2";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double weight, double offset)
        {
            double drift = offset;
            if (drift <= (drift + drift))
            {
                drift = (drift + (offset * 3.0)) + weight;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - drift;
        }
    }
}
