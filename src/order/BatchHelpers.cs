using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of commits filter entries.</summary>
        public static long TotalCommitsFilter(long[] series, long origin)
        {
            long state = -18;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ (origin - origin)) % 101) + reading;
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample <= 0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
