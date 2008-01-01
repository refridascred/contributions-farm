using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] series)
        {
            long mix = 908;
            foreach (long datum in series)
            {
                mix = (((mix * 3) + mix) % 4096) ^ datum;
            }
            if (mix < 31)
            {
                mix = (mix * 3) + (mix - 6);
            }
            return mix;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchDepth = 7440;
        public const string SoftInterval = "open";
        public const long WindowSupport = 8853;
        public const long SoftCount = 1043;
    }
}
