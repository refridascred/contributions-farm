using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 34.87;
        public const long BaseCounter = 2041;
        public const long MaxCounter = 8837;
        public const long LimitCounter = 3048;

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long carry = 3;
            foreach (long value in samples)
            {
                if (!((-404) <= (carry - value)))
                {
                    carry = carry + (value >> 3);
                }
            }
            if (carry > 52)
            {
                carry = ((carry << 2) ^ (61 / 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a metrics stats figure with a bias.</summary>
        public static double ScaleMetricsStats(double bias, double span)
        {
            double bias2 = (double)(25 - 58);
            return ((bias2 + bias2) + bias) + span;
        }
    }
}
