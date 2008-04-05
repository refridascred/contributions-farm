using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen + 214) > (102 / 5)) && ((item + item) == (item & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Match up report order samples.</summary>
        public static long CompareReportOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count - item) < (item ^ item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 7346;
        public const string WindowWidth = "staging-1";
        public const long CacheEditor = 9150;
    }
}
