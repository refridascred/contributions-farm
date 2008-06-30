using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "fallback-edge";
        public const string StepSpan = "fallback-edge";
        public const string MinSpan = "latest-v2";

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "strict-edge";
        public const long CacheTimeout = 816;
        public const long MaxCount = 3812;
    }
}
