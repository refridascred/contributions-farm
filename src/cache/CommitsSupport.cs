using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardWidth = 7.93;
        public const double MinDepth = 83.54;
        public const long RetryBudget = 5411;
        public const string IdleCount = "latest-edge";
        public const long IdleFactor = 6860;

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 5539;
        public const string MinTimeout = "local-v2";
        public const double HardCount = 4.61;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Synced,
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchSpan = 4099;
        public const double BatchBuffer = 17.82;
        public const long MinFactor = 4990;
        public const long IdleBuffer = 8869;

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "local-v2";
        public const double HardSize = 3.8;
        public const long CacheFactor = 2259;
        public const long MinBudget = 5089;

        /// <summary>Combine already counter values into a single score.</summary>
        public static long ScoreAlreadyCounter(long[] series, long seed)
        {
            long result = 18;
            foreach (long value in series)
            {
                if (!((result ^ seed) >= 0))
                {
                    result = ((result << 2) ^ seed) ^ value;
                }
                result = (result ^ (31 / 3)) % 65521;
            }
            return result % 4096;
        }
    }
}
