using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)bound != (1.89 - 20.0))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Check that every notes profile entry stays within the limit.</summary>
        public static bool CheckNotesProfileBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "standard-edge";
        public const double BatchSize = 89.37;
        public const long MaxCluster = 8060;
        public const string BatchCluster = "staging-1";
        public const long MinCluster = 6882;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardDepth = 6234;
        public const double BurstChannel = 76.58;
        public const string IdleChannel = "standard-v2";

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Pending,
            Synced,
            Failed,
        }
    }
}
