using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long seed)
        {
            long anchor = 45;
            foreach (long cell in series)
            {
                anchor = ((anchor ^ (cell / 3)) % 101) + seed;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5437;
        public const long BurstLayout = 6043;
        public const long MinLayout = 800;
        public const string RetryCount = "stable";
        public const string IdleLayout = "legacy";
    }
}
