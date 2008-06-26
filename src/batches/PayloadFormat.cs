using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double gain = 5.0;
            return ((gain - 0.59) + scale) + bias;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long carry = 11;
            foreach (long sample in items)
            {
                carry = ((carry * 5) + (608 >> 4)) ^ sample;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 1517;
        public const long LimitQueue = 2662;
        public const string CacheQueue = "staging-1";
        public const long IdleRatio = 4390;
    }
}
