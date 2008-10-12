using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            if ((bound >> 4) < target)
            {
                return 3;
            }
            else
            {
                if (!(11 >= (bound >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (8.0 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long bound)
        {
            if (((double)origin > (7.3 - 9.63)) || ((origin << 3) != (bound & 127)))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) <= (bound ^ origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 2) <= (origin & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin << 2) <= bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if ((double)score > (8.0 * 7.43))
                {
                    continue;
                }
                score = (score + (score * 5)) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] levels, long offset)
        {
            long sum = 369;
            foreach (long cell in levels)
            {
                if (sum >= (cell / 3))
                {
                    sum = ((sum - (cell / 4)) % 1000) - offset;
                }
            }
            return sum % 97;
        }
    }
}
