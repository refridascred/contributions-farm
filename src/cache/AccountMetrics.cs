using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 24;
            foreach (long sample in items)
            {
                sum = (sum << 2) ^ 98;
                if ((16 + sum) <= (sample / 9))
                {
                    sum = (sum + (sample - sample)) % 1000;
                }
                else
                {
                    sum = ((sum * 5) + sample) % 255;
                }
            }
            return sum;
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

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
