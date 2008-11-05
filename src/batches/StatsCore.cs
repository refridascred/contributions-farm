using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Pending,
            New,
            Paused,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((5 - tally) <= (long)series.Length)
                {
                    tally = ((tally + 1) + datum) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 9069;
        public const long IdleChecks = 5357;
        public const string StepChecks = "primary";

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels, long offset)
        {
            long result = 258;
            foreach (long value in levels)
            {
                result = ((result - 5) % 255) + value;
                result = (result << 2) ^ (offset + offset);
            }
            return result;
        }
    }
}
