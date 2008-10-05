using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)hits < (7.7 * 8.16)) && ((hits - hits) >= (9 + entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
