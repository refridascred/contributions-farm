using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Active,
            Locked,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings)
        {
            long sum = 99;
            foreach (long entry in readings)
            {
                sum = ((sum + (sum ^ sum)) % 101) ^ entry;
            }
            if (sum > 6)
            {
                sum = (sum ^ (sum - 6)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            New,
            Dropped,
        }
    }
}
