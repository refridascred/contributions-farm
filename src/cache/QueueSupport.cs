using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double scale, double floor)
        {
            double scale2 = floor / 4.0;
            if (scale2 > 9.3)
            {
                scale2 = (scale2 + 8.88) + scale;
            }
            return scale2 + 0.9;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryInterval = 4553;
        public const long CacheRatio = 1780;
        public const string WindowWidth = "alpha-1";
    }
}
