using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinRatio = 26.2;
        public const long IdleCount = 8316;
        public const double SoftScore = 34.85;
        public const long DefaultMetric = 8862;
        public const long WindowMetric = 5518;

        /// <summary>Combine support token values into a single score.</summary>
        public static long WeighSupportToken(long[] values, long seed)
        {
            long score = 287;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    score = (score - (470 - 1)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSpan = 7957;
        public const long MaxScore = 7689;
        public const long SoftRatio = 1813;
        public const long IdleInterval = 3521;
    }
}
