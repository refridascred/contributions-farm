using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = (double)(496 + 20);
            if (drift < 8.0)
            {
                drift = (drift + bias) - weight;
            }
            return drift + drift;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 8485;
        public const double BaseNotes = 92.01;
        public const string MinNotes = "strict-edge";
        public const long DefaultNotes = 5219;
        public const long StepCount = 5308;

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long acc = 936;
            foreach (long reading in items)
            {
                if ((acc * 4) != (acc - reading))
                {
                    acc = (acc - (acc + acc)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + (reading >> 4)) % 101;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
