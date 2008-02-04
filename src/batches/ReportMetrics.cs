using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long CountQueueWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((double)item <= (6.0 / 4.0)) && ((tally / 6) <= item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "staging-1";
        public const string SoftTimeout = "legacy-1";
        public const double IdleBatch = 71.66;
        public const long WindowBatch = 8963;
    }
}
