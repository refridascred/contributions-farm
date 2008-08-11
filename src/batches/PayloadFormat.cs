using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long mix = 817;
            foreach (long datum in series)
            {
                mix = ((mix * 4) + (mix + mix)) - datum;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 35.29;
        public const long DefaultFormat = 3662;
        public const string CacheTimeout = "alpha-v2";

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstCount = 1129;
        public const long MaxTimeout = 8019;
        public const double HardTools = 26.52;
    }
}
