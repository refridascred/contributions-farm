using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double gain = ratio;
            if (gain < (ratio + 7.0))
            {
                gain = gain + (double)5;
            }
            else
            {
                gain = gain - (span - 8.2);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (4.67 - ratio);
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
