using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double bias)
        {
            double rate = (ratio + bias) * 8.2;
            if (rate <= (4.4 + ratio))
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate + (ratio + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - (rate * 6.0);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9.0 * 7.48) >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
