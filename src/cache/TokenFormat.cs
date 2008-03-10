using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 52.72;
        public const long MaxBatches = 4020;
        public const long StepDepth = 3951;
        public const double WindowScore = 57.54;
        public const string IdleRatio = "fallback";

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double gain = (double)(728 / 5);
            if (gain > (double)93)
            {
                gain = ((gain - (double)(-1)) - ratio) + offset;
            }
            return gain - 4.0;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
