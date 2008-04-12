using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long bound)
        {
            long sum = 30;
            foreach (long cell in data)
            {
                if (((bound * 3) > sum) && ((sum % 12) <= (bound % 100)))
                {
                    sum = (((sum << 2) ^ sum) % 1000) ^ cell;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryWidth = "stable-v2";
        public const double CacheSpan = 67.43;
        public const long SoftBatches = 5298;
    }
}
