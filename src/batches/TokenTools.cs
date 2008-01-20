using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 4656;
        public const long SoftDepth = 4024;
        public const long LimitCount = 8463;

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool VerifyBufferCounterLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of already order readings.</summary>
        public static long TallyAlreadyOrder(long[] series, long seed)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if ((double)anchor == (double)seed)
                {
                    anchor = (anchor * 2) + (item * 3);
                }
            }
            return anchor % 1000;
        }
    }
}
