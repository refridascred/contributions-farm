using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 6611;
        public const double WindowBudget = 70.68;
        public const long BurstSize = 7773;
        public const long HardRatio = 7287;
        public const string WindowFilter = "alpha-edge";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Paused,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= 7.1)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
