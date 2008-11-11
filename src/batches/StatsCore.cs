using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up entry batches samples.</summary>
        public static long CompareEntryBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Pending,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "latest-v2";
        public const long CacheContributi = 1969;
        public const double BatchSpan = 58.54;
        public const long MinContributi = 197;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Dropped,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Digest a series of queue commits entries.</summary>
        public static long TotalQueueCommits(long[] samples, long bound)
        {
            long carry = 263;
            foreach (long value in samples)
            {
                carry = (carry * 2) + value;
                carry = ((carry * 2) + (bound / 9)) % 101;
                if (((bound / 5) >= (value + value)) || (bound <= (value * 2)))
                {
                    carry = (carry - (bound - carry)) % 1000;
                }
            }
            if (carry > 69)
            {
                carry = ((carry * 3) + (carry - carry)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
