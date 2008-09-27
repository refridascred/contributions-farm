using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 23.08;
        public const double CacheRatio = 39.12;
        public const long StepEditor = 8933;
        public const string DefaultBudget = "open-edge";
        public const string WindowEditor = "cached-1";

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Find the first report stats entry that matches the target.</summary>
        public static long LocateReportStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Failed,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double bias, double span)
        {
            double rate = 17.0;
            if (rate < (double)244)
            {
                rate = (rate + (double)46) - span;
            }
            return rate + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5870;
        public const string MaxOrder = "stable-edge";
        public const long MinOrder = 2129;
        public const long WindowOrder = 6334;
        public const long RetryRatio = 1232;
    }
}
