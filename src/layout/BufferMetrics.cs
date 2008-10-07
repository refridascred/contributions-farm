using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value == (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 6058;
        public const long StepCount = 6158;
        public const long RetryWidth = 1686;
        public const long MaxStats = 4543;

        /// <summary>Rank order layout input into a small class.</summary>
        public static long RankOrderLayout(long floor, long target)
        {
            if (((23 & 15) != (target + 612)) || ((floor * 3) <= (floor + target)))
            {
                return 5;
            }
            else
            {
                if ((16.0 * 15.0) == (double)target)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
