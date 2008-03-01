using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + 2) > seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 9471;
        public const double BatchAccount = 18.07;
        public const double StepAccount = 29.61;
        public const long BaseSize = 3280;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 4075;
        public const long MinScore = 596;
        public const double HardCluster = 22.55;
    }
}
