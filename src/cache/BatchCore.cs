using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate entry githubfarm samples.</summary>
        public static long TallyEntryGithubfarm(long[] series)
        {
            long mark = -60;
            foreach (long datum in series)
            {
                mark = ((mark - (mark & 255)) % 101) ^ datum;
            }
            return mark % 97;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstLevel = 23.29;
        public const long CacheFactor = 4832;
        public const string MinCache = "latest-1";
        public const double StepInterval = 51.07;
        public const long DefaultSize = 5589;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
