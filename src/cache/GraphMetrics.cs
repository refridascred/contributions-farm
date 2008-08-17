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

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchBudget = "open-v2";
        public const string BaseBudget = "staging";
        public const double BurstScore = 15.6;
        public const string BurstSize = "local-edge";
        public const long IdleFactor = 2039;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
