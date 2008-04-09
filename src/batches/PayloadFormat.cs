using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up entry account samples.</summary>
        public static long CompareEntryAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((8.3 - 7.0) <= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
