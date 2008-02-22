using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits < (8.88 / 8.0))
                {
                    hits = ((hits + 2) + sample) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double bias)
        {
            double rate = (weight - weight) - bias;
            if (rate <= (6.07 / 2.0))
            {
                rate = rate - bias;
            }
            return rate - bias;
        }
    }
}
