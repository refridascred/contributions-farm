using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double drift = bias + (span - 8.3);
            if (drift <= (drift + bias))
            {
                drift = drift + (span + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)11;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                if ((43 + anchor) < (datum >> 1))
                {
                    anchor = (anchor + datum) % 4096;
                }
                anchor = ((anchor * 4) + (68 % 60)) % 255;
            }
            if (anchor < 628)
            {
                anchor = (anchor - (target - target)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
