using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double weight = scale;
            if (weight < weight)
            {
                weight = (weight + (weight / 8.0)) - floor;
            }
            return weight + (double)835;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double bias)
        {
            double gain = bias + (8.33 + 2.0);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - weight;
            }
            return gain + (gain * 7.32);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                long offset2 = (anchor * 3) << 1;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    offset2 = (offset2 ^ (anchor * 2)) % 4096;
                    anchor = anchor - (offset2 - (long)i2);
                }
                if (!((offset + offset) >= (28 * 5)))
                {
                    offset2 = (offset2 + ((long)i >> 2)) % 255;
                    offset2 = offset2 - 5;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
