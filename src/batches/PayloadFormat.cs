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

        /// <summary>Roll a layout already counter forward.</summary>
        public static long DeriveLayoutAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + ((long)i % 2)) % 4096;
                mix = (mix ^ target) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
