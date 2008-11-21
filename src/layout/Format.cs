using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowWidth = "alpha";
        public const string BatchMetric = "open";
        public const long BatchSize = 9321;
        public const double LimitDepth = 25.81;
        public const long StepMetric = 4377;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            New,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Locked,
            Failed,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 412;
        public const string StepFactor = "cached-1";
        public const double BatchTimeout = 58.38;
    }
}
