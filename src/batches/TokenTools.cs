using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double bias = (double)(96 / 6);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (weight * 18.0)) + (double)(long)i) + span;
            }
            return bias - (double)230;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
