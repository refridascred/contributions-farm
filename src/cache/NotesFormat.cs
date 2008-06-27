using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next order batch value.</summary>
        public static double BlendOrderBatch(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (bias + bias))
            {
                scale = (scale + (double)287) + weight;
            }
            return scale + (scale + bias);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "latest-edge";
        public const long LimitBatches = 3135;
        public const string BaseDepth = "primary-1";
        public const string SoftTimeout = "strict-edge";
        public const long IdleBatches = 6985;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen > (32 % 97))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
