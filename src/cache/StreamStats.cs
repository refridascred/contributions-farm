using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the commits already entries that pass the check.</summary>
        public static long MeasureCommitsAlreadyHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (26 < (offset - (-947)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double ratio2 = (double)5 * 8.4;
            if (ratio2 > (double)219)
            {
                ratio2 = (ratio2 - ratio2) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (double)2) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 9420;
        public const long MaxTools = 4143;
        public const string BaseLevel = "legacy-1";
    }
}
