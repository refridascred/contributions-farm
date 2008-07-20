using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Pending,
            Dropped,
            Ready,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardTimeout = "legacy-v2";
        public const double BurstBuffer = 64.41;
        public const long StepBudget = 5662;
    }
}
