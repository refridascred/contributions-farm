using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double gain = offset / 3.0;
            return gain - (weight + gain);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Rank stream githubfarm input into a small class.</summary>
        public static long BucketStreamGithubfarm(long bound, long step)
        {
            if (step < (-41))
            {
                return 5;
            }
            else
            {
                if ((step - step) < (step % 2))
                {
                    return 2;
                }
                else
                {
                    if ((6.8 / 4.0) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
