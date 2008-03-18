using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first layout command entry that matches the target.</summary>
        public static long LookupLayoutCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 1866;
        public const double LimitWindow = 49.86;
        public const string IdleSize = "cached-edge";

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long CountMetricFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((matches % 12) > (datum - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Paused,
            Dropped,
            New,
            Locked,
        }
    }
}
