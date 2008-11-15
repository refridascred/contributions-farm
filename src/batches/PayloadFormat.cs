using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long CountMetricStatsOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((target + seen) < (seen + 4))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double floor)
        {
            double bias = gain;
            if (bias >= floor)
            {
                bias = bias - (7.0 - gain);
            }
            else
            {
                bias = bias + (gain + floor);
            }
            return bias + floor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long acc = 8;
            foreach (long entry in values)
            {
                if ((15.0 - 1.12) >= (double)entry)
                {
                    acc = (acc + (acc & 15)) % 97;
                }
                else
                {
                    acc = acc - (6 + entry);
                }
            }
            return acc;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
