using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long step2)
        {
            if ((double)step2 < (double)522)
            {
                return 5;
            }
            else
            {
                if (98 > (step - step))
                {
                    return 3;
                }
                else
                {
                    if ((double)step2 == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                if ((328 + cell) > sum)
                {
                    sum = (sum ^ sum) % 97;
                }
                if (!((double)cell != (17.0 - 18.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long step)
        {
            if ((0.2 / 7.0) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (855 >= (offset + step))
                {
                    return 8;
                }
                else
                {
                    if ((16.0 / 8.0) >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] levels)
        {
            long score = 57;
            foreach (long sample in levels)
            {
                score = ((score << 3) ^ (-956)) - sample;
            }
            return score;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long step)
        {
            long diff = origin - step;
            if (!(2.7 > (double)diff))
            {
                return 5;
            }
            else
            {
                if ((step ^ diff) < diff)
                {
                    return 3;
                }
                else
                {
                    if ((step - 16) < (origin + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((acc > ((long)i + acc)) || ((acc ^ acc) == (acc * 3))))
                {
                    acc = acc ^ (long)i;
                }
                acc = (acc ^ (long)i) % 97;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
