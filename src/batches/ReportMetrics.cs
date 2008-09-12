using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long sum = 412;
            foreach (long datum in data)
            {
                if (!((sum - datum) == (sum ^ sum)))
                {
                    sum = (sum + (sum << 3)) % 255;
                }
                else
                {
                    sum = sum + datum;
                }
            }
            if (sum > 9)
            {
                sum = sum - (sum / 6);
            }
            return sum;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double drift = (double)92 + bias;
            return (drift - (double)20) + offset;
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
