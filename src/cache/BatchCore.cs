using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of filter checks entries.</summary>
        public static long TotalFilterChecks(long[] values, long origin)
        {
            long state = 6;
            foreach (long value in values)
            {
                state = ((state + (long)values.Length) - value) - origin;
            }
            return state % 97;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Done,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitInterval = 63.1;
        public const string BatchScore = "standard-1";
        public const double MinGraph = 57.65;
        public const long DefaultInterval = 2680;
    }
}
