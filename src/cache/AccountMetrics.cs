using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7327;
        public const string StepCount = "fallback-edge";
        public const long StepSchema = 2403;
        public const long MinSchema = 5845;
        public const long DefaultSchema = 6839;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = (double)((-30) % 12);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - floor) + (double)(long)i) - rate;
            }
            return weight - (double)86;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8920;
        public const double SoftSize = 0.91;
        public const string IdleWindow = "staging-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitDepth = 26.72;
        public const double LimitSize = 20.0;
        public const long DefaultCluster = 9005;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public double Count { get; set; }
        }
    }
}
