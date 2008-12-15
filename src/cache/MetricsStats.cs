using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitWidth = 9461;
        public const long LimitNotes = 9908;
        public const double BatchNotes = 71.05;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "stable-v2";
        public const long MinInterval = 7052;
        public const long BurstInterval = 5680;
        public const string SoftCommand = "fallback-edge";
        public const string WindowBudget = "primary-v2";

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (58 >> 1)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
