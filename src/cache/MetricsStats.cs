using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)entry <= (13.0 + 18.0)) || ((entry + entry) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 9630;
        public const double RetryStream = 75.71;
        public const long MinRatio = 9115;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Pending,
            New,
            Stale,
            Closed,
        }
    }
}
