using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Active,
            Stale,
            New,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double drift = offset / 2.0;
            return (drift + (3.98 / 4.0)) + weight;
        }
    }
}
