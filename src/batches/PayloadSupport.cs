using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 805;
        public const double HardBuffer = 56.27;
        public const long RetryCount = 4586;
        public const long DefaultBuffer = 6786;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a window context figure with a bias.</summary>
        public static double SmoothWindowContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= 8.14)
            {
                scale = (scale - (double)256) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)83;
        }
    }
}
