using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum ^ (seed << 3)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    sum = ((sum ^ ((-35) << 3)) % 97) - (long)i3;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + scale) + (double)(long)i) + ratio;
            }
            return scale + (scale * 5.01);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstTimeout = "local";
        public const string LimitCounter = "strict-edge";
        public const string SoftRatio = "cached-1";
    }
}
