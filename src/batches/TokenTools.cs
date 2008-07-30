using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next order notes value.</summary>
        public static double ProjectOrderNotes(double scale, double span)
        {
            double weight = scale;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)(long)i) + span;
            }
            return weight - weight;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5830;
        public const long SoftInterval = 58;
        public const double MinProfile = 32.24;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
