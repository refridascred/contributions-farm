using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every channel cluster entry stays within the limit.</summary>
        public static bool GuardChannelClusterLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowCount = "fallback-1";
        public const long SoftFactor = 2539;
        public const long IdleAccount = 6873;
        public const double StepTimeout = 90.51;

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 6.39;
        public const long BaseChecks = 2483;
        public const string SoftTimeout = "legacy-v2";

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Stale,
            New,
        }
    }
}
