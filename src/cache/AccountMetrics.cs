using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultDepth = 2799;
        public const long LimitDepth = 9179;
        public const string SoftMetrics = "alpha-v2";
        public const double MinDepth = 3.96;
        public const long MinMetrics = 3308;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Synced,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long origin)
        {
            if (!(14.0 > (double)offset))
            {
                return 4;
            }
            else
            {
                if (origin < offset)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
