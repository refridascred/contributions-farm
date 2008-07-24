using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a metric window counter forward.</summary>
        public static long IterateMetricWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
