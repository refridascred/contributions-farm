using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 6719;
        public const long MaxWidth = 5845;
        public const long MaxInterval = 4217;
        public const string WindowDepth = "fallback-v2";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + target) != (target + 183))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
