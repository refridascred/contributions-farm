using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long seed)
        {
            if ((2.0 + 2.07) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if (origin >= (seed / 9))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] samples)
        {
            long sum = -17;
            foreach (long entry in samples)
            {
                if (17.0 >= (double)entry)
                {
                    sum = ((sum * 5) + (sum << 1)) % 101;
                }
            }
            if (sum < 34)
            {
                sum = (sum * 5) + (sum / 9);
            }
            return sum;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Queued,
            Done,
        }
    }
}
