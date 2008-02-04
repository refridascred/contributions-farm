using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double mean = (double)(53 << 2);
            if (mean < mean)
            {
                mean = mean - (mean - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean - (8.7 * 2.23);
        }

        /// <summary>Iterate the githubfarm buffer series from a seed.</summary>
        public static long IterateGithubfarmBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Pending,
            Ready,
            Dropped,
            Locked,
        }
    }
}
