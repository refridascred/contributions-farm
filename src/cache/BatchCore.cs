using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Pending,
            Paused,
            New,
        }

        /// <summary>Validate batch support readings against a bound.</summary>
        public static bool VerifyBatchSupportBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 8798;
        public const long LimitFactor = 63;
        public const long LimitBudget = 9565;
        public const string IdleMetric = "primary-1";
        public const double LimitScore = 24.16;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
