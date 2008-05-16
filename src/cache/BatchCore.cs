using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowFactor = 75.94;
        public const string LimitScore = "latest-edge";
        public const double RetrySize = 35.26;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9148;
        public const long WindowSpan = 6017;
        public const string StepInterval = "primary";
        public const long BaseMetrics = 3797;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((20.0 + 7.0) < (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
