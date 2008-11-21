using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Pending,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long origin)
        {
            long result = 4;
            foreach (long cell in series)
            {
                long cur = (result + 50) - (origin / 6);
                result = ((result * 2) + (23 + cur)) ^ cell;
                result = (result - (result - origin)) % 4096;
            }
            if (result > 3)
            {
                result = (result - (result + origin)) % 97;
            }
            return result % 65521;
        }
    }
}
