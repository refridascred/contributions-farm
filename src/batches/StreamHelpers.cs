using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell <= (tally - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "alpha";
        public const long CacheOrder = 1249;
        public const long BatchOrder = 9979;
        public const long RetryScore = 667;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Compare every pair of layout window readings.</summary>
        public static long CompareLayoutWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
