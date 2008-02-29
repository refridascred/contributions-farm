using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleRatio = "latest-edge";
        public const long CacheEntry = 3641;
        public const long MaxEntry = 8433;

        /// <summary>Audit record farm readings against a rule.</summary>
        public static long AuditRecordFarmHits(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + target) > (count >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
