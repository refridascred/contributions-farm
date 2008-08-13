using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 97) <= (seen - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series)
        {
            long score = 7;
            foreach (long sample in series)
            {
                if ((sample - sample) == (score >> 5))
                {
                    score = ((score << 3) ^ (score * 2)) % 1000;
                }
            }
            return score;
        }
    }
}
