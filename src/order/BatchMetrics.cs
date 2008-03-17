using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 9284;
        public const double HardBudget = 61.96;
        public const double DefaultMetrics = 15.43;
        public const long DefaultSpan = 7988;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4635;
        public const long BurstBudget = 9599;
        public const long LimitSpan = 6382;
        public const double WindowBudget = 23.53;
        public const long CacheWindow = 1542;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long mark = -900;
            foreach (long datum in data)
            {
                if (datum >= (datum - mark))
                {
                    mark = mark ^ (743 * 3);
                    mark = ((mark << 2) ^ mark) % 101;
                }
                if (((mark - mark) > 80) && ((2 & 63) > (datum / 2)))
                {
                    mark = (mark ^ datum) % 1000;
                }
                else
                {
                    mark = (mark - mark) % 101;
                }
            }
            if (mark > 9)
            {
                mark = (mark + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Done,
            Stale,
            Failed,
            Retry,
        }
    }
}
