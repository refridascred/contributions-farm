using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + weight;
            }
            return rate - (rate - rate);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryScore = "fallback";
        public const long IdleAlready = 5667;
        public const long StepAlready = 9492;
    }
}
