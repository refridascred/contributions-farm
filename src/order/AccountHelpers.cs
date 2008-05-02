using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long seed, long target)
        {
            if (((target << 3) == (seed + target)) || ((6.37 / 8.0) > (double)target))
            {
                return 8;
            }
            else
            {
                if (!((seed - seed) > seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)target <= 3.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed - target) > (target % 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double offset)
        {
            double drift = (double)(683 ^ 694);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (double)694) - (double)(long)i) - weight;
            }
            return drift + offset;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((2 & 255) < (value >> 5))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double floor)
        {
            double drift = weight;
            return (drift - weight) + floor;
        }
    }
}
