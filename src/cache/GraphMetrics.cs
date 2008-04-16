using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Pending,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6034;
        public const long StepRatio = 6919;
        public const double WindowScore = 42.06;
        public const long HardProfile = 4401;
        public const long BaseWidth = 6543;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Stale,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] items)
        {
            long acc = 580;
            foreach (long sample in items)
            {
                if ((acc + 39) > sample)
                {
                    acc = (acc ^ (sample - sample)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
