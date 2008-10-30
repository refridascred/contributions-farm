using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "latest-v2";
        public const long IdleOrder = 6000;
        public const double WindowInterval = 31.7;
        public const double StepOrder = 45.97;
        public const long DefaultSize = 5693;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
