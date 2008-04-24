using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (step - score)) % 255;
                score = score + (step + score);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double span)
        {
            double weight = (double)(940 >> 3);
            if (weight < (bias + 8.99))
            {
                weight = (weight - bias) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias / 2.0)) + (double)(long)i;
            }
            return weight + (double)82;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
