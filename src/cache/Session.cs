using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 68.68;
        public const double StepSupport = 36.2;
        public const long BatchSupport = 1856;
        public const double HardTimeout = 54.05;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Done,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Find the first profile commits entry that matches the target.</summary>
        public static long SeekProfileCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
