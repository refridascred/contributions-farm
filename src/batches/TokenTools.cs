using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double weight, double bias)
        {
            double ratio = (double)(-397) * 2.88;
            if (ratio > (weight + bias))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - weight;
        }
    }
}
