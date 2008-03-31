using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstLevel = 6733;
        public const long SoftScore = 541;
        public const long BurstCommits = 7962;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Failed,
            Retry,
        }
    }
}
