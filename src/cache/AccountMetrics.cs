using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

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

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowScore = "standard-v2";
        public const long StepCache = 7639;
        public const long HardFactor = 3105;
        public const double MinCache = 97.71;
        public const long HardCount = 1818;

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
