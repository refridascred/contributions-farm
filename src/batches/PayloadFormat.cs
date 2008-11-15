using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double weight, double floor)
        {
            double bias = floor;
            if (bias > weight)
            {
                bias = bias - (bias + bias);
            }
            else
            {
                bias = bias + (floor - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (weight + weight);
        }

        /// <summary>Scale a cluster stream figure with a bias.</summary>
        public static double ScaleClusterStream(double scale, double offset)
        {
            double drift = (scale - scale) * 4.0;
            if (drift < drift)
            {
                drift = (drift + (scale * 1.78)) + offset;
            }
            return drift + scale;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long acc = 8;
            foreach (long entry in values)
            {
                if ((15.0 - 1.12) >= (double)entry)
                {
                    acc = (acc + (acc & 15)) % 97;
                }
                else
                {
                    acc = acc - (6 + entry);
                }
            }
            return acc;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
