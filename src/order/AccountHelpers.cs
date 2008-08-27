using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((acc << 3) < (6 ^ 0))
                {
                    acc = ((acc - acc) % 1000) ^ value;
                }
                else
                {
                    acc = acc - (acc + (-58));
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long floor)
        {
            long diff = target - floor;
            if (((double)floor <= (15.0 - 7.0)) && ((5.25 - 11.0) < (double)diff))
            {
                return 6;
            }
            else
            {
                if (((target << 1) <= (diff / 3)) && (floor > target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every layout order entry stays within the limit.</summary>
        public static bool VerifyLayoutOrderBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Dropped,
            Synced,
            Locked,
            Done,
        }
    }
}
