using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Region { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            New,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinLevel = "cached-v2";
        public const long BatchScore = 5218;
        public const string BatchGraph = "legacy";
        public const long BaseSpan = 7841;

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double gain = (1.06 - bias) - bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias + span)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
