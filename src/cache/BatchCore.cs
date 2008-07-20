using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((15.0 * 0.3) != (double)tally)
                {
                    tally = ((tally + 3) ^ value) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 4703;
        public const long RetrySupport = 4411;
        public const long IdleSize = 1032;
        public const long BatchLevel = 8724;
        public const long StepSupport = 3614;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
