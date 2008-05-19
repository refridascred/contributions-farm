using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels, long offset)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                mix = (mix + (offset << 1)) + cell;
                if ((double)(long)levels.Length <= (12.0 - 3.7))
                {
                    mix = (mix << 3) ^ 44;
                }
            }
            if (mix < 631)
            {
                mix = mix + (offset ^ mix);
            }
            return mix;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double weight = 4.9;
            return (weight - (bias + bias)) + offset;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = score - ((long)i * 3);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
