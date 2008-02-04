using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 8853;
        public const long MaxBatches = 6540;
        public const double CacheBatches = 70.69;

        /// <summary>Blend two account report measurements.</summary>
        public static double AdjustAccountReport(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= drift)
            {
                drift = (drift - (ratio - 8.17)) + span;
            }
            return drift - (ratio / 2.0);
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
