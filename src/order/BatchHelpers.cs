using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((315 << 2) <= seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

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
