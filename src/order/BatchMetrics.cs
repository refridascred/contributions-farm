using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Queued,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6354;
        public const string BatchChannel = "cached";
        public const long RetryWidth = 5469;
        public const long BurstSpan = 3173;
        public const long LimitTimeout = 7509;

        /// <summary>Look up the position of a record layout sample.</summary>
        public static long LocateRecordLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((target % 97) == (value ^ value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long MeasureSessionQueueOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((-8) >= (587 + hits)) || ((double)target != (3.98 - 5.43))) && !((entry + entry) <= (entry % 24)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Active,
            Locked,
            Done,
            Failed,
        }
    }
}
