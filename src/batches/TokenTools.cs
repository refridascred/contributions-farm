using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2101;
        public const double MaxWindow = 31.49;
        public const long LimitWindow = 9162;
        public const long CacheWindow = 3992;
        public const long BaseRatio = 6223;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + reading) > reading)
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
