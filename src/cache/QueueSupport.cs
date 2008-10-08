using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the report buffer entries that pass the check.</summary>
        public static long TallyReportBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count > (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLevel = 7800;
        public const long MaxWidth = 9315;
        public const double HardSpan = 36.99;
    }
}
