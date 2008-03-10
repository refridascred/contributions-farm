using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 8815;
        public const long MaxPayload = 5106;
        public const long RetryPayload = 1756;
        public const long LimitPayload = 2036;
        public const string CacheCount = "strict";

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double gain = bias;
            if (gain < (double)38)
            {
                gain = gain - (bias2 * 10.0);
            }
            return gain - gain;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
