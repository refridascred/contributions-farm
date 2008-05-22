using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4681;
        public const long CacheSize = 2764;
        public const double HardPayload = 95.78;
        public const string BaseWidth = "cached";

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "strict-v2";
        public const double CacheCluster = 82.42;
        public const string StepFactor = "primary-edge";

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((double)origin == (6.46 + 4.2))
                {
                    mix = (mix + (mix >> 5)) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (31 / 3);
                    mix = mix + ((long)i % 2);
                }
                if (!((8.4 / 5.0) > (double)origin))
                {
                    mix = (mix + ((long)i ^ mix)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
