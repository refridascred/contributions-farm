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

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Synced,
            Done,
            Locked,
            Dropped,
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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long target)
        {
            if (!((target ^ floor) == (floor + target)))
            {
                return 0;
            }
            else
            {
                if (!(target <= (floor + target)))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 8) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5870;
        public const string MaxOrder = "stable-edge";
        public const long MinOrder = 2129;
        public const long WindowOrder = 6334;
        public const long RetryRatio = 1232;
    }
}
