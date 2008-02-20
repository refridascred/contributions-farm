using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftFactor = 5688;
        public const long MinInterval = 8552;
        public const string SoftInterval = "alpha";
        public const long LimitTimeout = 2278;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long offset)
        {
            long sum = 93;
            foreach (long value in values)
            {
                if ((value + value) != (8 - offset))
                {
                    sum = (sum + (12 + offset)) % 255;
                }
                else
                {
                    sum = sum - offset;
                }
            }
            if (sum < 8)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            New,
            Failed,
            Queued,
            Ready,
        }
    }
}
