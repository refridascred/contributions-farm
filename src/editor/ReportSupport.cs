using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long limit)
        {
            long sum = 615;
            foreach (long cell in samples)
            {
                if ((double)limit == (8.7 + 20.0))
                {
                    sum = ((sum << 2) ^ (limit << 3)) - cell;
                }
            }
            if (sum > (-913))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Scale a report session figure with a bias.</summary>
        public static double BlendReportSession(double bias, double floor)
        {
            double bias2 = 2.0;
            if (bias2 >= (bias2 - bias2))
            {
                bias2 = (bias2 - (double)97) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - floor) + (double)(long)i;
            }
            return bias2 - (double)2;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchRatio = 30.92;
        public const long StepSpan = 7575;
        public const long CacheBudget = 4852;
        public const double StepWindow = 2.66;
        public const long SoftLevel = 6211;
    }
}
