using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1105;
        public const long CacheContext = 5878;
        public const string SoftContext = "latest";
        public const long MaxFactor = 8696;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] samples)
        {
            long carry = 93;
            foreach (long item in samples)
            {
                carry = ((carry << 3) ^ (carry % 64)) % 101;
                carry = (carry << 2) ^ item;
            }
            return carry % 65521;
        }

        /// <summary>Adjust a layout farm reading.</summary>
        public static double AdjustLayoutFarm(double ratio, double span)
        {
            double scale = span;
            if (scale < scale)
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (span * 6.1);
        }
    }
}
