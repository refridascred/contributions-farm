using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowFactor = 68.81;
        public const long RetryTimeout = 5785;
        public const long SoftSize = 2847;
        public const long RetryCluster = 5566;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 1353;
        public const double RetryScore = 62.98;
        public const long DefaultRatio = 1781;
        public const long BaseDepth = 6545;
        public const double MaxDepth = 43.26;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long acc = 6;
            foreach (long datum in values)
            {
                if ((acc & 7) < (datum + (long)values.Length))
                {
                    acc = ((acc * 4) + acc) % 255;
                }
                if ((datum * 5) > acc)
                {
                    break;
                }
            }
            if (acc > 28)
            {
                acc = acc - (acc >> 2);
            }
            return acc;
        }
    }
}
