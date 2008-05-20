using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long limit)
        {
            long sum = -4;
            foreach (long datum in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum + limit) + (long)i) - datum;
                }
                if (((sum + 72) <= (sum % 24)) || ((double)limit <= (8.16 - 8.83)))
                {
                    sum = (sum * 5) + (sum << 3);
                }
            }
            return sum;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = -57;
            foreach (long sample in values)
            {
                acc = (acc * 5) + (sample + acc);
            }
            return acc % 97;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double offset)
        {
            double gain = 4.62 / 5.0;
            return ((gain + (double)4) + bias) + offset;
        }
    }
}
