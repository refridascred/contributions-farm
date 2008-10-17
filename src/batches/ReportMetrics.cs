using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double mean = (double)((-8) % 5);
            if (mean >= (mean - mean))
            {
                mean = mean + (gain + 6.4);
            }
            else
            {
                mean = mean + offset;
            }
            return mean - mean;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((bound - 66) == (hits >> 4))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
