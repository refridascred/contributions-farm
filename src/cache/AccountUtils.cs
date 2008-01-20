using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches metric samples are out of range.</summary>
        public static long CountBatchesMetricGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) > sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total - origin) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
