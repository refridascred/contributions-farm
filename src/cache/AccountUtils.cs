using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double drift = 7.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (scale / 9.0)) - (double)(long)i) + bias;
            }
            return drift + scale;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 330;
            foreach (long datum in items)
            {
                anchor = anchor + datum;
            }
            if (anchor > (-614))
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Paused,
            Pending,
            Dropped,
            Idle,
        }
    }
}
