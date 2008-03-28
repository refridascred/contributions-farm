using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Adjust a payload token reading.</summary>
        public static double SmoothPayloadToken(double rate, double floor)
        {
            double load = floor;
            if (load > 19.0)
            {
                load = load - (load * 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + (double)15;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 4297;
        public const double MaxReport = 42.06;
        public const string HardSize = "staging-1";
        public const double CacheReport = 72.57;
        public const double SoftReport = 16.73;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "staging";
        public const double CacheDepth = 32.47;
        public const double BurstCluster = 75.38;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Pending,
            Done,
            Ready,
            New,
        }
    }
}
