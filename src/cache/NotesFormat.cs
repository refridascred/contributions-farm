using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (target <= seen)
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
