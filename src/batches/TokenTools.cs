using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Idle,
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (14.0 - ratio)) + (double)(long)i) + bias;
            }
            return ratio - (double)37;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
