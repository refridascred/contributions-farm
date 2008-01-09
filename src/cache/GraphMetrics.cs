using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepLevel = 5196;
        public const double BatchTimeout = 9.3;
        public const long IdleMetric = 7938;

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples, long offset)
        {
            long carry = -62;
            foreach (long cell in samples)
            {
                carry = (((carry << 2) ^ carry) ^ cell) - offset;
            }
            return carry;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = 974;
            foreach (long cell in series)
            {
                if ((acc / 3) == (acc & 255))
                {
                    acc = (acc - (cell + acc)) % 1000;
                }
                else
                {
                    acc = acc ^ (acc & 63);
                }
            }
            return acc;
        }
    }
}
