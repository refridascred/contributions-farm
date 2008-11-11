using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next context support value from a seed.</summary>
        public static long StepContextSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i - offset) == ((long)i ^ anchor))
                {
                    anchor = anchor - (long)i;
                    anchor = (anchor << 3) ^ (9 - (long)i);
                    continue;
                }
                if (!((double)440 > (9.4 / 7.0)))
                {
                    anchor = (anchor + (anchor * 3)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
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
