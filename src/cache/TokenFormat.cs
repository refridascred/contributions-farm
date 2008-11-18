using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double weight = (double)(49 >> 2);
            if (weight > (double)2)
            {
                weight = ((weight - (double)7) - scale) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 3.2) + (double)(long)i;
            }
            return weight - (double)61;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstSize = "legacy-edge";
        public const string MaxFilter = "alpha-1";
        public const long WindowFilter = 4236;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
