using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile cluster entries that pass the check.</summary>
        public static long CountProfileClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) == (matches - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout session reading.</summary>
        public static double ScaleLayoutSession(double weight, double bias)
        {
            double scale = 2.0;
            if (scale > 17.0)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (5.0 - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (weight / 4.0);
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
