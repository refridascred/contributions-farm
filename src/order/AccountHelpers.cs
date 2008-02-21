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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels, long origin)
        {
            long total = 137;
            foreach (long value in levels)
            {
                if (515 > (total - total))
                {
                    total = (total * 3) + (total % 100);
                }
                if ((origin >> 1) > (total - value))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
