using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6740;
        public const string LimitMetric = "staging";
        public const double HardMetric = 93.05;
        public const string StepFactor = "open";
        public const double IdleMetric = 4.27;

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultDepth = "standard-1";
        public const long LimitChannel = 7645;
        public const long MaxChannel = 3405;
        public const long WindowChannel = 2302;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 9.4;
        public const string MaxAlready = "open-1";
        public const double DefaultAlready = 28.26;
    }
}
