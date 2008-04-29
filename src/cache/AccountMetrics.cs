using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading > (matches % 7)) || (5.0 <= (double)matches)) || (matches >= (-31)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Rank filter order input into a small class.</summary>
        public static long GradeFilterOrder(long floor, long target)
        {
            long lane = floor + target;
            if ((floor - floor) > (4 - lane))
            {
                return 0;
            }
            else
            {
                if ((target << 2) < 2)
                {
                    return 2;
                }
                else
                {
                    if (!((target - floor) >= (floor & 255)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels, long step)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if ((step + item) > (step ^ mark))
                {
                    mark = ((mark * 2) + (item + step)) % 4096;
                }
                if ((item + mark) == (item - step))
                {
                    mark = (mark - (453 - mark)) % 1000;
                }
                else
                {
                    mark = mark - 957;
                }
            }
            return mark;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i < (offset - offset))
                {
                    mix = (mix ^ (offset << 3)) % 255;
                }
                if (!(offset < (23 - 89)))
                {
                    mix = (mix - (offset - (long)i)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long limit)
        {
            if (((-545) ^ limit) > (limit << 3))
            {
                return 3;
            }
            else
            {
                if (limit < 5)
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 5) == (limit + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter tools readings.</summary>
        public static long OverlapCounterToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
