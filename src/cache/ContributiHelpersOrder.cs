using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5256;
        public const long IdleBudget = 2706;
        public const long RetryCount = 4481;
        public const string BurstCount = "fallback-edge";

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
