using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheSpan = 6342;
        public const double CacheCluster = 58.5;
        public const long RetryBudget = 2897;
        public const long LimitCluster = 7415;
        public const string BatchCluster = "strict-v2";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ limit) == (limit / 8))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((82 >> 5) <= (count & 7)) || ((datum ^ datum) > (datum ^ 3))) || (((datum + 908) > (count & 15)) && ((datum + count) <= (count ^ datum))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
