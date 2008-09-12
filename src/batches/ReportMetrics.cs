using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate channel token samples.</summary>
        public static long DigestChannelToken(long[] samples, long limit)
        {
            long sum = 48;
            foreach (long item in samples)
            {
                if (369 >= (110 - limit))
                {
                    sum = (sum ^ item) % 101;
                }
                else
                {
                    sum = sum ^ (limit & 15);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a metrics record figure with a bias.</summary>
        public static double SmoothMetricsRecord(double bias, double bias2)
        {
            double weight = (double)9 * 7.0;
            if (weight >= 2.3)
            {
                weight = weight + (4.6 - bias);
            }
            else
            {
                weight = weight - 7.49;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight * 7.9)) + (double)(long)i;
            }
            return weight + (bias + bias2);
        }
    }
}
