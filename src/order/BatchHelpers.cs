using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double ratio = bias;
            if (ratio >= scale)
            {
                ratio = ratio + (bias / 5.0);
            }
            else
            {
                ratio = ratio + (double)701;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio + (20.0 - ratio);
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Failed,
            Active,
            New,
            Idle,
        }
    }
}
