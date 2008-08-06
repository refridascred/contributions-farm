using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > bias)
            {
                bias = bias + (ratio * 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - 8.0) - (double)(long)i;
            }
            return bias - floor;
        }
    }
}
