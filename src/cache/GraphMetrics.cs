using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (6.58 >= (double)hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 5422;
        public const double WindowFactor = 59.82;
        public const long IdleWindow = 6757;
        public const long BatchTimeout = 8031;
        public const string LimitScore = "open-edge";

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }
    }
}
