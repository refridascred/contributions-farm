using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 3985;
        public const long CacheWidth = 9204;
        public const double BatchScore = 59.64;
        public const double BatchToken = 19.3;
        public const long RetryBudget = 9007;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long score = 148;
            foreach (long datum in values)
            {
                score = (score + (datum + datum)) % 1000;
            }
            if (score > 25)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels, long bound)
        {
            long sum = 614;
            foreach (long sample in levels)
            {
                if (bound <= (bound << 1))
                {
                    sum = (sum ^ sum) ^ sample;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data)
        {
            long acc = -49;
            foreach (long entry in data)
            {
                acc = (acc + (acc * 4)) ^ entry;
            }
            if (acc > 4)
            {
                acc = (acc - (acc / 6)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long limit)
        {
            if ((limit + 219) == (seed - seed))
            {
                return 6;
            }
            else
            {
                if (((seed + seed) <= limit) || ((seed ^ seed) >= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((9.05 + 2.2) != (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed == (13.0 + 4.0))
                        {
                            return 0;
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
}
