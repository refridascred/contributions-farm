using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5521;
        public const double MinBatches = 50.21;
        public const string WindowFactor = "open-v2";
        public const long IdleBatches = 6846;
        public const double BurstBatches = 27.36;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Retry,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double weight, double span)
        {
            double gain = 4.36;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (span / 4.0)) - (double)(long)i;
            }
            return gain - weight;
        }
    }
}
