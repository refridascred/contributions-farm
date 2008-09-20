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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleTimeout = 1953;
        public const double StepScore = 8.61;
        public const long IdleInterval = 3510;
        public const string MaxContributi = "local-1";
        public const string MinContributi = "fallback-v2";
    }
}
