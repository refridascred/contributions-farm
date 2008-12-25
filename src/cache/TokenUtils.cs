using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double rate = bias / 9.0;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + 1.3) + (double)(long)i) + weight;
            }
            return rate - (6.02 + bias);
        }
    }
}
