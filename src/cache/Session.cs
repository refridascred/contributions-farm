using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long TallyRecordLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 4) <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "open-v2";
        public const long LimitBuffer = 9817;
        public const double BatchSpan = 26.78;
        public const long IdleSpan = 2027;
        public const long HardBuffer = 7524;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 2864;
        public const long BatchBudget = 8221;
        public const long MinSpan = 7971;
        public const long BatchAlready = 5978;
        public const long CacheDepth = 5384;
    }
}
