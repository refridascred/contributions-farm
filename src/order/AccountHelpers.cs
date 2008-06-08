using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleScore = 4.97;
        public const double BurstLevel = 11.38;
        public const string CacheBudget = "strict-1";

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if ((double)reading != (17.0 / 5.0))
                {
                    score = score ^ (reading ^ reading);
                }
            }
            if (score > (-9))
            {
                score = ((score * 2) + (score << 3)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Failed,
            Active,
            Ready,
        }
    }
}
