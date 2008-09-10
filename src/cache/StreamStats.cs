using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "cached-1";
        public const double BurstDepth = 68.5;
        public const long WindowRatio = 9866;
        public const long MinRoute = 2824;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseLevel = 2374;
        public const long StepCache = 801;
        public const long DefaultSpan = 2320;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5885;
        public const long MaxLevel = 2061;
        public const long HardLevel = 2748;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long offset, long offset2)
        {
            if ((121 & 127) > (offset2 % 100))
            {
                return 7;
            }
            else
            {
                if (!((offset << 2) >= offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
