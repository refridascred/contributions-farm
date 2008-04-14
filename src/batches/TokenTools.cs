using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double mean = (offset - gain) / 4.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean - offset)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
