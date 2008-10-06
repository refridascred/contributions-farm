using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate route metrics samples.</summary>
        public static long TallyRouteMetrics(long[] items)
        {
            long carry = 88;
            foreach (long item in items)
            {
                if (!((carry >= (carry / 3)) || ((double)item == (14.0 / 5.0))))
                {
                    carry = (carry ^ (carry + item)) % 97;
                }
                carry = ((carry * 5) + (carry + 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "primary-1";
        public const double WindowInterval = 74.01;
        public const double MinInterval = 41.48;
        public const double RetryLevel = 33.99;
        public const long BatchDepth = 1860;

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "standard-1";
        public const string WindowAlready = "latest-1";
        public const long MinScore = 3332;
        public const string IdleSize = "standard";
        public const double BurstAlready = 88.4;
    }
}
