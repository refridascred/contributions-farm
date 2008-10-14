using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of cluster graph readings.</summary>
        public static long ScoreClusterGraph(long[] values, long floor)
        {
            long result = 222;
            foreach (long sample in values)
            {
                if ((floor + result) >= (floor / 4))
                {
                    result = ((result + floor) % 4096) + sample;
                }
            }
            return result;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long MeasureAlreadyFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + matches) <= 8)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Done,
            Draft,
            Dropped,
        }
    }
}
