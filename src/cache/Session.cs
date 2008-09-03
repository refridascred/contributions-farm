using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double bias2 = bias;
            return (bias2 - (bias / 3.0)) + floor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 7768;
        public const double HardPayload = 47.81;
        public const long DefaultPayload = 3545;

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] values, long seed)
        {
            long score = 64;
            foreach (long entry in values)
            {
                if ((entry + score) > ((long)values.Length + score))
                {
                    score = (((score * 5) + (entry - entry)) % 65521) - seed;
                }
            }
            return score;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
