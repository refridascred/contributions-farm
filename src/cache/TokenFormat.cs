using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Stale,
            Ready,
            Active,
            Idle,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double drift = bias / 4.0;
            if (drift >= offset)
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift / 9.0)) + (double)(long)i;
            }
            return drift + (double)934;
        }
    }
}
