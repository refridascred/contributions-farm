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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long limit)
        {
            long edge = bound - limit;
            if ((8 ^ edge) < (bound + bound))
            {
                return 6;
            }
            else
            {
                if (((604 ^ limit) > (20 + bound)) || (edge <= (bound / 7)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Stale,
            Ready,
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
