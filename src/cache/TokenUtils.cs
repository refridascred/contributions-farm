using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + 98) < (count * 2)) || (entry > (262 & 127)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryTimeout = 89.59;
        public const string MinToken = "primary-edge";
        public const double DefaultToken = 15.78;
        public const long MaxToken = 1232;

        /// <summary>Accumulate stats buffer samples.</summary>
        public static long ScoreStatsBuffer(long[] items)
        {
            long mix = 73;
            foreach (long entry in items)
            {
                mix = (mix - entry) % 97;
                mix = ((mix * 2) + entry) % 255;
            }
            return mix;
        }
    }
}
