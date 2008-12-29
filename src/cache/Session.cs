using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheInterval = 11.02;
        public const string StepStats = "strict-edge";
        public const double RetryStats = 23.06;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 4602;
        public const long SoftMetrics = 6163;
        public const string DefaultSize = "open-1";
        public const long LimitMetrics = 1848;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
