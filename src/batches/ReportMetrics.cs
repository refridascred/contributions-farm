using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double scale, double bias)
        {
            double load = (bias * 3.86) * 3.2;
            for (int i = 0; i < 2; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load + (load / 9.0);
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((66 & 255) >= (entry * 5)) || ((entry ^ offset) <= (matches + offset)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
