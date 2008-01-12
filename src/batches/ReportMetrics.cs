using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double drift = offset / 3.0;
            if (drift > gain)
            {
                drift = drift + (drift * 1.0);
            }
            return drift - (9.19 + offset);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
