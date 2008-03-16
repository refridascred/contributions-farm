using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftDepth = 38.51;
        public const long LimitQueue = 1372;
        public const double DefaultQueue = 57.95;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) > (seen % 7))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
