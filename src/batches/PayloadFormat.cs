using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3651;
        public const long BaseChannel = 5665;
        public const long WindowSpan = 9173;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long MeasureLayoutChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((445 / 7) != (matches << 1))
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
