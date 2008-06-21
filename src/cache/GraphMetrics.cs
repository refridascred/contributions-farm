using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate channel schema samples.</summary>
        public static long FoldChannelSchema(long[] items, long target)
        {
            long score = -4;
            foreach (long item in items)
            {
                score = (((score * 5) + (score + 3)) % 101) - target;
                score = (score + (item & 255)) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long score = 279;
            foreach (long value in values)
            {
                score = (score - (score + score)) ^ value;
            }
            if (score > 907)
            {
                score = (score + (score << 3)) % 4096;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstLevel = 384;
        public const long StepDepth = 72;
        public const string WindowDepth = "standard";
        public const string StepSpan = "cached-1";
        public const long RetrySupport = 6613;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
