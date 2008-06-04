using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate graph layout samples.</summary>
        public static long WeighGraphLayout(long[] levels)
        {
            long acc = 775;
            foreach (long reading in levels)
            {
                acc = (((acc << 2) ^ (acc % 97)) % 4096) ^ reading;
            }
            return acc;
        }

        /// <summary>Validate stats notes readings against a bound.</summary>
        public static bool CheckStatsNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Ready,
            Pending,
            New,
            Locked,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Failed,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy-v2";
        public const long LimitBatches = 176;
        public const long LimitRatio = 3412;
        public const double MinBatches = 12.78;
        public const long BurstRatio = 1429;
    }
}
