using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 <= gain)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias / 3.0);
            }
            return bias2 - (double)441;
        }
    }
}
