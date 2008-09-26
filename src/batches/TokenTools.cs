using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((5.8 - 4.71) >= (double)seen)
                {
                    seen = (seen + 1) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
