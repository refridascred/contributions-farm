using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length > reading)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(((5.7 / 3.0) > (double)step) || ((anchor >> 5) >= (anchor ^ 32))))
                {
                    anchor = ((anchor * 3) + (3 + step)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate cache command readings against a bound.</summary>
        public static bool GuardCacheCommandRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
