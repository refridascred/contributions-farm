using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 8412;
        public const string BurstTimeout = "local";
        public const long RetryCluster = 6144;
        public const long BurstSize = 5140;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix - (mix >> 4)) % 4096) + (long)i2;
                }
                mix = (mix + (long)i) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 84.2;
        public const long BaseInterval = 2241;
        public const string DefaultOrder = "latest-1";
        public const string CacheCount = "stable-edge";
        public const long BaseScore = 8486;
    }
}
