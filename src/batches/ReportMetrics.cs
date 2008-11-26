using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = 29;
            foreach (long sample in samples)
            {
                if ((anchor >> 4) >= sample)
                {
                    anchor = (anchor + (anchor + sample)) % 97;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor ^ (anchor + 989);
            }
            return anchor;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Classify a contributi batches pair into a bucket.</summary>
        public static long SortContributiBatches(long offset, long offset2)
        {
            if ((double)offset2 != (14.0 + 5.99))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset2) <= (offset2 + offset))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
