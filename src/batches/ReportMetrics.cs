using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double rate = (double)((-108) << 2);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - gain) + (double)(long)i) - span;
            }
            return rate - (double)(-6);
        }

        /// <summary>Find the first stream counter entry that matches the target.</summary>
        public static long LocateStreamCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
