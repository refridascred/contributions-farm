using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 5935;
        public const long StepLevel = 8768;
        public const long BaseTimeout = 9414;
        public const long MaxToken = 7097;
        public const string MaxCount = "primary-1";

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double ratio = (double)(148 * 4);
            if (ratio > gain)
            {
                ratio = ratio - (double)614;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
