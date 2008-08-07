using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 6577;
        public const double CacheLevel = 89.32;
        public const long WindowChecks = 8517;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (-3);
                state = (state - (state - state)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
