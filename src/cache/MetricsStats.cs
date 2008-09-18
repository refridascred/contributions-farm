using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ ((long)items.Length + entry)) % 255;
                if ((total < (entry & 63)) && ((18.0 - 4.86) < (double)total))
                {
                    total = (total << 3) ^ (entry * 3);
                }
            }
            return total;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Draft,
            Locked,
            Idle,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 9964;
        public const string DefaultScore = "fallback-v2";
        public const long BaseWidth = 1531;
        public const long DefaultSize = 4679;
        public const long LimitFormat = 2694;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
