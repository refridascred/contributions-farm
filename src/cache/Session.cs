using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Failed,
            Active,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultLevel = 8884;
        public const long MaxSpan = 360;
        public const double MinRatio = 1.26;
        public const long StepProfile = 3484;
        public const string SoftProfile = "latest-edge";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
