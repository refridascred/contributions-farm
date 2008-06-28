using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit metric profile readings against a rule.</summary>
        public static long CountMetricProfileMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((item + item) > (count - count)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = ((score << 2) ^ score) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 8014;
        public const long BaseReport = 9903;
        public const long DefaultSize = 3998;
    }
}
