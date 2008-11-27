using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Project the next graph report value.</summary>
        public static double ProjectGraphReport(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)756)
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + 4.0) + (double)(long)i;
            }
            return ratio - (double)8;
        }
    }
}
