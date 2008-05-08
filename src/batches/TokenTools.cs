using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2496;
        public const long BurstFactor = 7739;
        public const string HardWindow = "fallback-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9561;
        public const string IdleBatches = "strict-1";
        public const double MaxBatches = 58.1;
    }
}
