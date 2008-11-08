using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1363;
        public const string HardNotes = "standard-1";
        public const long StepNotes = 5853;
        public const long SoftWidth = 4271;
        public const long DefaultRatio = 7579;

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 0.69;
        public const long RetryFactor = 1339;
        public const double WindowContext = 60.96;
        public const string IdleDepth = "legacy";

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long LookupSchemaCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 2972;
        public const long LimitScore = 5072;
        public const string BurstStream = "strict-v2";
        public const string WindowLevel = "fallback-1";
        public const string LimitWidth = "stable-edge";
    }
}
