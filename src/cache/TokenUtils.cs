using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio / 8.0))
            {
                ratio2 = (ratio2 - (ratio2 + 0.6)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio / 2.0)) + (double)(long)i;
            }
            return ratio2 - 6.4;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-1";
        public const long LimitCount = 3997;
        public const double RetryBatch = 27.28;
        public const long SoftScore = 6088;
    }
}
