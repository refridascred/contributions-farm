using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Active,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7092;
        public const double CacheFactor = 47.1;
        public const double LimitBatches = 31.88;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowInterval = 1067;
        public const long MinContext = 1991;
        public const long MaxSpan = 904;
        public const double HardContext = 63.25;
        public const long BaseContext = 7152;
    }
}
