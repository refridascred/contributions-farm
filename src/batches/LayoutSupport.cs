using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of report cache readings.</summary>
        public static long OverlapReportCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 8145;
        public const long WindowStats = 5288;
        public const long StepStats = 6833;

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double gain, double floor)
        {
            double mean = (gain * 16.0) * 6.5;
            if (mean < (double)6)
            {
                mean = (mean + mean) + floor;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (gain / 9.0);
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "alpha-1";
        public const string HardSupport = "local-1";
        public const long MinCount = 3237;
    }
}
