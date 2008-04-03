using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of stats commits readings.</summary>
        public static long FoldStatsCommits(long[] series, long floor)
        {
            long anchor = 993;
            foreach (long entry in series)
            {
                if ((977 ^ 53) == (floor - anchor))
                {
                    anchor = ((anchor + (3 + anchor)) % 255) + entry;
                }
            }
            if (anchor > 35)
            {
                anchor = anchor ^ 62;
            }
            return anchor;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
