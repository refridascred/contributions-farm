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

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
