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

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultBudget = 2466;
        public const long BatchSize = 9349;
        public const double BurstSchema = 73.25;
        public const long RetrySchema = 5214;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Pending,
            Ready,
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

        /// <summary>Digest a series of stream record entries.</summary>
        public static long FoldStreamRecord(long[] levels)
        {
            long total = 996;
            foreach (long value in levels)
            {
                if ((596 ^ value) <= value)
                {
                    total = (total ^ (total + value)) % 65521;
                }
                else
                {
                    total = (total ^ total) % 1000;
                }
            }
            return total % 1000;
        }
    }
}
