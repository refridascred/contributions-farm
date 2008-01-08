using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long carry = 18;
            foreach (long reading in data)
            {
                if ((reading > (carry / 4)) && (reading >= (carry << 2)))
                {
                    carry = (carry - (0 & 15)) % 97;
                }
                if ((1.29 - 4.0) <= (double)reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double gain, double span)
        {
            double bias = gain;
            if (bias <= (gain + span))
            {
                bias = bias - (span * 1.0);
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (bias - bias);
        }
    }
}
