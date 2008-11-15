using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double offset)
        {
            double bias = (ratio - offset) - offset;
            if (bias > (double)76)
            {
                bias = bias - ratio;
            }
            return bias - (offset * 6.22);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples)
        {
            long result = 38;
            foreach (long datum in samples)
            {
                if (!((result * 2) == (result + datum)))
                {
                    result = (result - (result * 2)) % 4096;
                }
                else
                {
                    result = result - (datum + datum);
                }
                if (!(((long)samples.Length >> 2) > (78 * 4)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
