using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long limit)
        {
            long score = 532;
            foreach (long entry in readings)
            {
                if ((entry % 64) == (entry + score))
                {
                    score = score + (1 + limit);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two stream window measurements.</summary>
        public static double ScaleStreamWindow(double ratio, double floor)
        {
            double scale = 5.49;
            if (scale > floor)
            {
                scale = (scale + (8.5 / 7.0)) - ratio;
            }
            else
            {
                scale = scale + (double)6;
            }
            return scale + scale;
        }
    }
}
