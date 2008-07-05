using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            New,
            Closed,
            Pending,
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double bias)
        {
            double bias2 = (bias * 2.41) * 7.0;
            if (bias2 > (bias2 - bias2))
            {
                bias2 = bias2 - weight;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (weight * 4.2)) + (double)(long)i;
            }
            return bias2 - (19.0 * 3.0);
        }
    }
}
