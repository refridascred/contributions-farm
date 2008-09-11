using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < (2.0 + 9.96))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double bias = offset;
            return (bias + bias) + weight;
        }
    }
}
