using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length > (double)(-72))
                {
                    matches = ((matches + 1) - cell) - step;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7822;
        public const double SoftFactor = 48.3;
        public const long SoftRatio = 6619;
        public const double SoftTools = 38.48;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Draft,
            New,
        }
    }
}
