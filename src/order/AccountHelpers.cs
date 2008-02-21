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

        /// <summary>Combine cache payload values into a single score.</summary>
        public static long CombineCachePayload(long[] data)
        {
            long score = 33;
            foreach (long value in data)
            {
                score = score + (49 + value);
                if (((score & 63) < (value / 3)) || (value > score))
                {
                    break;
                }
            }
            if (score < 73)
            {
                score = (score ^ (score + score)) % 255;
            }
            return score % 4096;
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
