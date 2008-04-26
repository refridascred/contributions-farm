using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultDepth = 5881;
        public const double RetryScore = 94.71;
        public const long DefaultInterval = 6947;
        public const string MaxInterval = "latest-v2";

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((cell + count) < (cell + cell)) || ((count < (count ^ count)) && ((8.0 / 9.0) == (double)cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Stale,
            Active,
            Pending,
            Closed,
        }
    }
}
