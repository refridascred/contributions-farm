using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double drift = (bias2 - bias2) * 5.0;
            return drift + (bias * 19.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepTimeout = 64.6;
        public const long BaseMetric = 9631;
        public const long BatchMetric = 516;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 5687;
        public const long RetryTimeout = 2567;
        public const long SoftStats = 4326;
        public const double BatchStats = 86.46;
    }
}
