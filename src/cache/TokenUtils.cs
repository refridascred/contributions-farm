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

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
