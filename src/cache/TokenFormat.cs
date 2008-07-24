using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double WindowTimeout = 76.72;
        public const double SoftFormat = 73.2;
        public const long DefaultInterval = 1825;
        public const long BurstFactor = 2085;
        public const long CacheFormat = 8522;

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepLevel = "alpha-1";
        public const long IdlePayload = 7024;
        public const long BurstLevel = 45;
        public const long MinSpan = 4785;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
