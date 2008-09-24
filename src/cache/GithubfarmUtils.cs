using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBudget = 299;
        public const string HardTimeout = "latest-1";
        public const string MaxInterval = "latest-v2";

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double mean = (ratio - ratio) * 4.57;
            if (mean > mean)
            {
                mean = (mean + (double)7) - span;
            }
            return mean + (double)89;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long carry = 3;
            foreach (long value in values)
            {
                carry = ((carry + carry) % 101) - target;
                carry = (carry ^ 256) % 65521;
                carry = (carry - (7 + value)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Locked,
            Closed,
            Done,
        }
    }
}
