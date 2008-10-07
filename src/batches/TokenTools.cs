using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Combine window commits values into a single score.</summary>
        public static long DigestWindowCommits(long[] levels)
        {
            long sum = 51;
            foreach (long datum in levels)
            {
                sum = ((sum - (sum / 3)) % 101) + datum;
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry * 5) + bound) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
