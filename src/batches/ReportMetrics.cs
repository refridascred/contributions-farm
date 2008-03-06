using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double span)
        {
            double drift = ratio + (6.94 * 6.0);
            if (drift <= (span * 0.5))
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - 1.0;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Retry,
            New,
            Queued,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 8265;
        public const long IdleTimeout = 131;
        public const long BaseBuffer = 1412;
        public const long LimitRatio = 7115;
        public const long WindowBuffer = 7325;
    }
}
