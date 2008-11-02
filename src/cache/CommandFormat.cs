using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Idle,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultLevel = 614;
        public const long BatchInterval = 5834;
        public const long DefaultCluster = 6728;
        public const long MaxBudget = 6144;
        public const long LimitTimeout = 9222;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
