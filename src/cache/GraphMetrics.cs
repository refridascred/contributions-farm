using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings, long bound)
        {
            long state = 19;
            foreach (long entry in readings)
            {
                if ((double)bound == (8.0 * 4.2))
                {
                    state = ((state << 3) ^ (state - 8)) - entry;
                }
                else
                {
                    state = ((state << 2) ^ (539 + 74)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4967;
        public const string BatchQueue = "staging-v2";
        public const string IdleQueue = "stable";

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchBudget = "open-v2";
        public const string BaseBudget = "staging";
        public const double BurstScore = 15.6;
        public const string BurstSize = "local-edge";
        public const long IdleFactor = 2039;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Draft,
            Active,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Active,
            Pending,
        }
    }
}
