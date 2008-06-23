using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitInterval = 2876;
        public const double WindowSize = 53.6;
        public const string LimitQueue = "legacy";
        public const string BurstLevel = "local";
        public const double IdleQueue = 40.12;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "alpha-v2";
        public const long WindowContext = 5994;
        public const string DefaultContext = "standard-v2";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Token { get; set; }
            public bool Label { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double gain = floor;
            return gain + (weight + 4.48);
        }
    }
}
