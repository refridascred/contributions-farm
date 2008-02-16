using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double floor)
        {
            double bias = (double)(24 ^ 77);
            if (bias <= (ratio - ratio))
            {
                bias = bias + (double)62;
            }
            return bias - floor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftLevel = 84.11;
        public const long BurstFactor = 3483;
        public const double MinCount = 53.46;
        public const long MinDepth = 1750;
    }
}
