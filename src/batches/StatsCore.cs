using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (993 <= (sample - sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

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
