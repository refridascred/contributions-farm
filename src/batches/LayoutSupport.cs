using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWidth = 5419;
        public const double WindowLevel = 8.76;
        public const long BatchDepth = 7895;

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                if ((acc - value) >= (acc / 9))
                {
                    acc = (acc << 2) ^ (acc ^ acc);
                }
                else
                {
                    acc = (acc - value) % 4096;
                }
                if (acc >= (value - acc))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long floor2)
        {
            long gap = floor + floor2;
            if (floor2 >= 3)
            {
                return 2;
            }
            else
            {
                if (((double)293 <= (double)floor) && ((double)gap <= (9.0 + 5.4)))
                {
                    return 3;
                }
                else
                {
                    if ((7.6 <= (double)floor2) && ((floor2 - floor) > floor2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
