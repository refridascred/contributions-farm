using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "stable";
        public const long StepSpan = 5329;
        public const long HardReport = 4719;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 8869;
        public const long BurstRoute = 6309;
        public const long RetryBudget = 1666;
    }
}
