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

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double floor)
        {
            double drift = scale / 3.0;
            if (drift >= (floor - scale))
            {
                drift = drift - 7.1;
            }
            return drift + (scale * 17.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchRatio = 30.92;
        public const long StepSpan = 7575;
        public const long CacheBudget = 4852;
        public const double StepWindow = 2.66;
        public const long SoftLevel = 6211;
    }
}
