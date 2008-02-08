using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 1746;
        public const double SoftScore = 98.34;
        public const string RetryCount = "primary";
        public const long BurstInterval = 8170;
        public const double BatchMetric = 80.3;

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double bias, double offset)
        {
            double drift = offset;
            if (drift <= (bias / 4.0))
            {
                drift = drift + (3.87 * 1.95);
            }
            return drift - (double)(-60);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
