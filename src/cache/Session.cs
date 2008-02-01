using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context support measurements.</summary>
        public static double AdjustContextSupport(double rate, double span)
        {
            double drift = (rate * 20.0) * 4.92;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCount = "cached-v2";
        public const double CacheCounter = 87.86;
        public const string SoftSpan = "standard-v2";
        public const double StepCounter = 62.99;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Queued,
            Idle,
        }
    }
}
