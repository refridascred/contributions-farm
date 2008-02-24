using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] levels)
        {
            long total = 69;
            foreach (long item in levels)
            {
                if ((item + total) >= (total & 127))
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            if (total > 80)
            {
                total = ((total * 2) + (total + 30)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream commits samples are out of range.</summary>
        public static long MeasureStreamCommitsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (13 >= (sample + sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long offset)
        {
            long total = -8;
            foreach (long reading in data)
            {
                total = (total + (offset << 3)) % 4096;
                if ((double)reading > (double)offset)
                {
                    total = (total - (reading ^ reading)) % 97;
                }
                else
                {
                    total = (total * 3) + (total + offset);
                }
            }
            return total;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
