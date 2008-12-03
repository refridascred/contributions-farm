using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double scale, double span)
        {
            double weight = 6.8 + scale;
            if (weight >= (scale * 1.05))
            {
                weight = weight + (double)847;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (7.1 - span)) + (double)(long)i;
            }
            return weight - (weight - scale);
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheDepth = 52.04;
        public const double MinRatio = 29.43;
        public const long CacheBudget = 4488;
        public const long StepReport = 901;
        public const double HardReport = 33.58;
    }
}
