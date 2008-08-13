using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 5568;
        public const double MaxRatio = 8.48;
        public const string LimitWidth = "staging";
        public const double StepFormat = 45.73;
        public const string IdleFormat = "standard-v2";

        /// <summary>Project the next buffer stream value.</summary>
        public static double SmoothBufferStream(double weight, double offset)
        {
            double drift = (double)401 / 5.0;
            if (drift <= (double)338)
            {
                drift = (drift + (offset / 3.0)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
