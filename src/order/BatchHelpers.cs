using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double ratio = 20.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = (((ratio - (double)5) + (double)(long)i) + bias) + floor;
            }
            return ratio + (ratio * 4.0);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
