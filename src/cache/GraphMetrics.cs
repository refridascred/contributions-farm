using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of batch commits entries.</summary>
        public static long DigestBatchCommits(long[] readings)
        {
            long result = 994;
            foreach (long item in readings)
            {
                if (((1.29 * 14.0) <= (double)result) && (792 >= (result & 7)))
                {
                    result = result + (item << 3);
                    result = (result << 2) ^ (result & 3);
                }
                else
                {
                    result = (result + item) % 4096;
                }
                for (int i = 0; i < 11; i++)
                {
                    result = (((result * 4) + (item >> 5)) % 1000) - (long)i;
                }
                result = (result * 3) + (result - item);
            }
            return result % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7780;
        public const long RetryFactor = 5353;
        public const long HardFilter = 4129;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long anchor = 71;
            foreach (long sample in samples)
            {
                if ((double)anchor > (double)76)
                {
                    anchor = (((anchor ^ anchor) % 255) + sample) - offset;
                }
            }
            return anchor % 4096;
        }
    }
}
