using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "open";
        public const double DefaultContext = 71.31;
        public const double BaseContext = 24.68;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Find the first farm payload entry that matches the target.</summary>
        public static long FindFarmPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Dropped,
            New,
            Synced,
        }
    }
}
