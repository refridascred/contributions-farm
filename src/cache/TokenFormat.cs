using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9015;
        public const double MinWidth = 80.55;
        public const long IdleCache = 8183;
        public const long SoftSpan = 5307;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double weight, double floor)
        {
            double gain = 8.0;
            if (gain >= (floor / 9.0))
            {
                gain = gain + (double)(-55);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (floor * 2.0)) + (double)(long)i;
            }
            return gain + (floor - weight);
        }
    }
}
