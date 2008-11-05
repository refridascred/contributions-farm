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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length << 3) < offset)
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
