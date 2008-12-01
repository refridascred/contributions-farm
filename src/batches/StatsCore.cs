using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Paused,
            Pending,
            New,
            Active,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < 7.4)
            {
                rate = (rate - (double)(-6)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (ratio - ratio)) + (double)(long)i;
            }
            return rate + (double)322;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if ((double)offset > (2.22 / 8.0))
            {
                return 2;
            }
            else
            {
                if (52 > (step >> 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long target)
        {
            long sum = 3;
            foreach (long reading in levels)
            {
                sum = ((sum + (sum ^ 531)) ^ reading) + target;
            }
            return sum;
        }

        /// <summary>Accumulate counter cache samples.</summary>
        public static long CombineCounterCache(long[] values, long target)
        {
            long sum = 151;
            foreach (long value in values)
            {
                sum = ((sum ^ (value + 60)) % 65521) + target;
            }
            if (sum < 66)
            {
                sum = sum + (long)values.Length;
            }
            return sum % 97;
        }

        /// <summary>Find the first githubfarm checks entry that matches the target.</summary>
        public static long FindGithubfarmChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
