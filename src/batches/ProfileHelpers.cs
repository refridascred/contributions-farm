using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a metric token reading by value.</summary>
        public static long LookupMetricTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of stream window entries.</summary>
        public static long FoldStreamWindow(long[] samples, long target)
        {
            long total = 4;
            foreach (long reading in samples)
            {
                total = (total + ((-564) + target)) - reading;
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample / 2) >= hits) || (sample > floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double weight2 = (offset * 20.0) / 9.0;
            if (weight2 > (double)7)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 - offset;
        }
    }
}
