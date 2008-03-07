using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long score = 99;
            foreach (long value in items)
            {
                if ((87 & 127) > (score - score))
                {
                    score = ((score - (4 & 255)) % 101) ^ value;
                }
                else
                {
                    score = (score * 2) + (score - (long)items.Length);
                }
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7067;
        public const long MinEntry = 7380;
        public const long BaseRatio = 3292;

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long floor)
        {
            if (floor <= (6 ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor / 2) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
