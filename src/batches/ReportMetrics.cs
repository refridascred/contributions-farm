using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double floor)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = (weight + (double)66) + floor;
            }
            return weight - 0.7;
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
