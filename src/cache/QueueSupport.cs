using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSize = 7110;
        public const long MaxDepth = 3405;
        public const long BatchContext = 7835;
        public const long CacheCount = 8196;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-v2";
        public const long RetryRatio = 5693;
        public const double MaxScore = 38.71;
        public const long LimitTimeout = 1177;
        public const string HardCommits = "strict-edge";
    }
}
