using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "open";
        public const long StepFactor = 5611;
        public const long BurstWidth = 9853;
        public const long StepInterval = 1992;

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] series)
        {
            long carry = 5;
            foreach (long datum in series)
            {
                carry = ((carry + (448 << 3)) % 1000) - datum;
            }
            if (carry > 239)
            {
                carry = ((carry << 3) ^ (carry % 100)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
