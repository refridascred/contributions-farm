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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value > (3 * 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchDepth = "latest";
        public const string IdleBudget = "legacy-1";
        public const string HardSpan = "cached";
        public const long CacheAlready = 2185;
    }
}
