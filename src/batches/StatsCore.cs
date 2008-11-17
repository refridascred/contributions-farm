using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Match up metrics queue samples.</summary>
        public static long MatchMetricsQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2968;
        public const long RetryEditor = 7976;
        public const long BaseLevel = 3286;
        public const long CacheDepth = 390;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 9811;
        public const string CacheCount = "staging-edge";
        public const long DefaultRatio = 5289;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
