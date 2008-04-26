using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window already value from a seed.</summary>
        public static long StepWindowAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i <= 3.3)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 23.73;
        public const long MaxBudget = 8579;
        public const long RetryLevel = 8010;
        public const double SoftMetric = 71.23;
        public const long BatchMetric = 3803;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "primary-edge";
        public const double MinWidth = 84.95;
        public const long DefaultMetrics = 518;
        public const long DefaultRatio = 8802;
    }
}
