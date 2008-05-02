using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleCount = 5460;
        public const string BurstLevel = "latest-edge";
        public const long WindowScore = 228;
        public const double SoftFarm = 81.14;
        public const long HardFarm = 884;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long total = 4;
            foreach (long datum in readings)
            {
                total = total ^ (datum + 875);
            }
            return total % 97;
        }
    }
}
