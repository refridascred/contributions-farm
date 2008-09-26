using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double load = bias2;
            if (load >= (20.0 / 9.0))
            {
                load = (load - (double)710) - bias;
            }
            else
            {
                load = load - load;
            }
            return load + load;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two commits checks measurements.</summary>
        public static double ScaleCommitsChecks(double weight, double bias)
        {
            double weight2 = weight;
            return (weight2 - weight) + bias;
        }
    }
}
