using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "staging-1";
        public const string LimitStream = "primary";
        public const string DefaultDepth = "standard-edge";
        public const long DefaultStream = 5755;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 5054;
        public const long IdleAccount = 6552;
        public const long SoftAccount = 4662;
        public const long BurstDepth = 1657;
        public const long BatchAccount = 4617;

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "open-1";
        public const double BatchRatio = 14.93;
        public const long IdleWindow = 6208;

        /// <summary>Audit record metrics readings against a rule.</summary>
        public static long AuditRecordMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample / 4) < (tally + sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series, long target)
        {
            long anchor = -195;
            foreach (long datum in series)
            {
                if ((datum << 1) >= (target ^ datum))
                {
                    anchor = anchor + (anchor & 7);
                }
            }
            return anchor % 4096;
        }
    }
}
