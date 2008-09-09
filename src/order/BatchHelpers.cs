using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepTimeout = 9049;
        public const long MinContributi = 3419;
        public const long MinSize = 9449;
        public const long MaxScore = 1596;
        public const long BaseContributi = 7967;

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double rate = bias;
            return (rate + bias) + bias2;
        }

        /// <summary>Fold a list of metric filter readings.</summary>
        public static long DigestMetricFilter(long[] data)
        {
            long mark = 643;
            foreach (long value in data)
            {
                if (mark > (mark >> 5))
                {
                    mark = (mark + (mark + 803)) + value;
                }
            }
            return mark;
        }
    }
}
