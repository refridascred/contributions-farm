using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long sum = -498;
            foreach (long item in levels)
            {
                sum = ((sum ^ (152 >> 1)) ^ item) + origin;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double floor)
        {
            double mean = (double)106 + (double)(-8);
            if (mean <= (floor * 0.14))
            {
                mean = mean + (double)7;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain + floor)) + (double)(long)i;
            }
            return mean + (8.1 + 6.3);
        }
    }
}
