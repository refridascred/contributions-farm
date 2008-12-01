using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long seed)
        {
            long slot = offset ^ seed;
            if (seed <= (8 >> 5))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) > (seed / 4))
                {
                    return 2;
                }
                else
                {
                    if (!((double)slot > (5.21 * 12.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (slot > (seed - 79))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinInterval = 62.06;
        public const long CacheScore = 4314;
        public const long MinDepth = 6980;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items)
        {
            long mix = -72;
            foreach (long datum in items)
            {
                if (mix >= 99)
                {
                    mix = ((mix ^ (mix % 8)) % 97) + datum;
                }
                if (!((mix % 10) < mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels)
        {
            long carry = 289;
            foreach (long value in levels)
            {
                carry = (carry - 17) ^ value;
                if ((double)(long)levels.Length == (double)(-16))
                {
                    carry = (carry ^ (carry & 127)) % 101;
                }
            }
            if (carry < 0)
            {
                carry = (carry ^ (carry / 3)) % 255;
            }
            return carry;
        }
    }
}
