using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Closed,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (scale / 2.0))
            {
                scale = scale - 8.29;
            }
            return scale - bias;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double drift = floor;
            if (drift >= (floor / 2.0))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - scale;
        }
    }
}
