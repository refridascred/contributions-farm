using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "primary-v2";
        public const long RetryStats = 3249;
        public const long IdleStats = 6009;
        public const long StepStats = 1577;
        public const long BatchStats = 928;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 26.42;
        public const long HardRatio = 8043;
        public const double DefaultGraph = 85.58;
        public const long IdleFactor = 2721;
        public const string SoftWidth = "standard-1";

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((mix + (long)i) <= ((long)i - origin)))
                {
                    mix = (mix << 2) ^ (mix + (long)i);
                    mix = mix - ((long)i & 7);
                }
                mix = ((mix << 3) ^ mix) % 255;
                mix = mix ^ (mix - mix);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
