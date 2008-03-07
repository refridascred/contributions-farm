using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((420 + 44) > matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 9496;
        public const long BatchRatio = 1826;
        public const long BatchSize = 1506;
        public const long DefaultFactor = 8246;
    }
}
