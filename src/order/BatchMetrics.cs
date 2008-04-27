using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many filter schema samples are out of range.</summary>
        public static long AuditFilterSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen > (4.1 * 9.8))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Retry,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            Active,
            Done,
        }
    }
}
