using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a batch stream reading.</summary>
        public static double SmoothBatchStream(double gain, double bias)
        {
            double bias2 = (double)((-463) + 906);
            if (bias2 > (9.2 + bias2))
            {
                bias2 = (bias2 - (double)2) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - gain;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!!((floor + 26) != (4 * 2)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
