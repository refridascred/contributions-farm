using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstRatio = 9639;
        public const long BaseLayout = 5917;
        public const long RetryLayout = 325;
        public const double MinLayout = 59.94;
        public const string BaseScore = "staging";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally >= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
