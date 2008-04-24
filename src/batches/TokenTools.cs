using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5548;
        public const long WindowQueue = 4245;
        public const long RetryRatio = 6727;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (double)99)
            {
                scale2 = (scale2 - scale) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + scale2) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
