using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Idle,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double scale = (double)81 * 0.9;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - floor;
            }
            return scale - (scale - weight);
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Idle,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data)
        {
            long mark = -4;
            foreach (long sample in data)
            {
                if (sample < (mark + 7))
                {
                    mark = mark + (sample ^ sample);
                }
                if ((double)mark <= (2.4 + 3.2))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 3) ^ ((long)data.Length >> 1);
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double rate = gain + (floor / 7.0);
            return rate + 3.4;
        }
    }
}
