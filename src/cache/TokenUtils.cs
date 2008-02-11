using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long sum = 862;
            foreach (long value in items)
            {
                if (!((double)value < 2.4))
                {
                    sum = (sum << 3) ^ (85 - sum);
                }
                sum = sum - value;
            }
            if (sum > 9)
            {
                sum = (sum + (sum << 3)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Synced,
            Idle,
        }
    }
}
