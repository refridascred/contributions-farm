using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Draft,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double weight = (double)((-2) - 37);
            if (weight <= (span / 6.0))
            {
                weight = weight - (9.22 * 1.21);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if ((entry + entry) >= (carry % 2))
                {
                    carry = (carry - (74 & 15)) - bound;
                }
            }
            if (carry > (-87))
            {
                carry = (carry + (carry << 1)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 3772;
        public const string BurstRecord = "standard-v2";
        public const long BatchDepth = 8471;
        public const long MaxRecord = 4952;
    }
}
