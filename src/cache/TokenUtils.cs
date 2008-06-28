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

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long offset)
        {
            long span = target ^ offset;
            if (span <= (offset + (-21)))
            {
                return 4;
            }
            else
            {
                if ((target + offset) > ((-753) - offset))
                {
                    return 5;
                }
                else
                {
                    if (((span - offset) == (target / 6)) && (span < offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (7 < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 8014;
        public const long BaseReport = 9903;
        public const long DefaultSize = 3998;
    }
}
