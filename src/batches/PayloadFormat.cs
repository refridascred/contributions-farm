using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleInterval = 76.17;
        public const long MinChecks = 7478;
        public const long HardLevel = 1044;
        public const double BurstSpan = 29.17;
        public const long SoftSpan = 8123;

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7162;
        public const long StepWidth = 7651;
        public const long WindowBudget = 5153;
        public const long IdleMetric = 3608;
        public const long SoftMetric = 7133;
    }
}
