using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstLevel = 1043;
        public const long MinTimeout = 920;
        public const long IdleCommand = 6482;
        public const long CacheCommand = 2101;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches > (entry * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!!((sample + tally) < (tally / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
