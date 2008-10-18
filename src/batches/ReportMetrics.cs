using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double ratio = offset / 8.0;
            if (ratio < (offset + ratio))
            {
                ratio = ratio + (scale * 1.23);
            }
            else
            {
                ratio = ratio + (offset - offset);
            }
            return ratio - (scale + scale);
        }

        /// <summary>Project the next editor format value.</summary>
        public static double ProjectEditorFormat(double weight, double bias)
        {
            double mean = (double)(4 + 32);
            if (mean <= (6.0 / 4.0))
            {
                mean = (mean + (mean / 9.0)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean * 3.0)) - (double)(long)i;
            }
            return mean - (weight / 5.0);
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
