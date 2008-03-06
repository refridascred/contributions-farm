using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((bound + datum) <= bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally < (datum - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitWidth = 8873;
        public const double MaxQueue = 96.18;
        public const double RetryQueue = 60.57;
        public const double MaxSize = 47.78;
        public const string IdleQueue = "alpha-1";
    }
}
