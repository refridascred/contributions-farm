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

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
