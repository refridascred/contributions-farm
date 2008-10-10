using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9221;
        public const double MinSize = 47.32;
        public const long BurstFormat = 8657;
        public const string LimitFormat = "open-edge";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((4 - limit) < matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Match up support already samples.</summary>
        public static long PairSupportAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the buffer account entries that pass the check.</summary>
        public static long AuditBufferAccountGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((20.0 * 4.5) < (double)(long)items.Length)
                {
                    count = ((count + 1) - item) + limit;
                }
            }
            return count;
        }
    }
}
