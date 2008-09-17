using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double bias2 = (double)(21 + 820);
            if (bias2 <= (double)31)
            {
                bias2 = (bias2 + 7.6) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias2 + bias)) + (double)(long)i;
            }
            return bias2 - (bias / 5.0);
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 2) ^ (8 % 2);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 83.13;
        public const double MinQueue = 15.44;
        public const string LimitQueue = "latest-1";
    }
}
