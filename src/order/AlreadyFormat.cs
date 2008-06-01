using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 54.39;
        public const long RetryFilter = 6549;
        public const long MaxSpan = 7395;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 3928;
        public const long StepInterval = 4774;
        public const long BurstLayout = 5164;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheBudget = 6898;
        public const long SoftChecks = 2745;
        public const long SoftBudget = 3293;
        public const string CacheChecks = "latest-1";
    }
}
