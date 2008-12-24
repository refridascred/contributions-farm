using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data)
        {
            long carry = -5;
            foreach (long sample in data)
            {
                carry = ((carry * 3) + (carry << 3)) ^ sample;
            }
            if (carry < 269)
            {
                carry = (carry ^ (carry * 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double bias = 4.0 - (double)9;
            if (bias <= rate)
            {
                bias = (bias + (rate + bias)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (bias * 9.0)) + (double)(long)i;
            }
            return bias - (bias / 9.0);
        }
    }
}
