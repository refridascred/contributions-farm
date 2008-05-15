using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double mean = scale;
            return (mean - (mean + mean)) + span;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleBudget = "stable-edge";
        public const string BurstScore = "legacy-v2";
        public const long CacheFormat = 2451;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
