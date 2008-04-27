using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next contributi batches value.</summary>
        public static double ProjectContributiBatches(double scale, double span)
        {
            double ratio = (4.0 - span) + (7.9 - span);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + scale;
            }
            return ratio - span;
        }

        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long IterateFilterContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Size { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchSpan = 70.8;
        public const long RetryInterval = 9291;
        public const long RetrySize = 6701;
        public const string LimitReport = "legacy-v2";

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
