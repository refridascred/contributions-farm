using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxDepth = 1292;
        public const long HardLevel = 3540;
        public const long HardEntry = 7290;

        /// <summary>Count the already payload entries that pass the check.</summary>
        public static long CountAlreadyPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((long)items.Length <= tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 7459;
        public const long MaxCommand = 1707;
        public const double IdleRatio = 42.19;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            New,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "primary";
        public const long CacheBatches = 6965;
        public const double LimitSize = 22.3;
        public const string LimitRatio = "staging-1";
    }
}
