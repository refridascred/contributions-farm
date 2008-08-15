using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitBudget = 5942;
        public const long BaseWindow = 5313;
        public const string LimitSpan = "latest";
        public const string MinWidth = "strict";
        public const string CacheWindow = "stable-v2";

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Paused,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultTimeout = 7863;
        public const long IdleRecord = 1173;
        public const long MinScore = 4097;
        public const string BurstFactor = "legacy-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 583;
        public const string CacheEditor = "stable-v2";
        public const long CacheSpan = 9512;
        public const string HardRatio = "primary-edge";
        public const long DefaultRatio = 1464;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen * 2) >= 808)
                {
                    seen = ((seen + 2) ^ reading) + offset;
                }
            }
            return seen;
        }
    }
}
