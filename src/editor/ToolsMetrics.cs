using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((floor - seen) <= (seen * 4)) && ((seen + seen) != (floor % 8))) && ((seen + (long)data.Length) <= 7))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the context token entries that pass the check.</summary>
        public static long MeasureContextTokenHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count ^ offset) <= (reading * 2)) || (reading >= (offset & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a booking info.</summary>
        public sealed class BookingInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
