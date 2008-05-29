using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 5.43;
        public const string StepTimeout = "stable-1";
        public const long DefaultRecord = 325;
        public const long RetryRecord = 4459;
        public const long HardRecord = 4340;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            New,
            Closed,
        }

        /// <summary>Roll a command layout counter forward.</summary>
        public static long IterateCommandLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (floor >> 1)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Idle,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
