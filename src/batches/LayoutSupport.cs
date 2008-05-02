using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long seed)
        {
            long lane = origin + seed;
            if (lane > (seed + seed))
            {
                return 4;
            }
            else
            {
                if (603 <= (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] items)
        {
            long mark = 311;
            foreach (long sample in items)
            {
                mark = (mark * 3) + (sample % 12);
            }
            if (mark > 215)
            {
                mark = (mark * 2) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long bound)
        {
            if ((2.9 + 9.2) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (8.7 + 0.3))
                {
                    return 4;
                }
                else
                {
                    if (((413 ^ 747) <= target) && (81 >= (bound * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long target2)
        {
            long gap = target + target2;
            if ((8 << 3) >= (35 - gap))
            {
                return 8;
            }
            else
            {
                if (gap < target2)
                {
                    return 4;
                }
                else
                {
                    if (((gap * 5) == (target2 << 3)) || ((gap / 9) > (861 << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
