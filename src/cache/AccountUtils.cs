using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 1063;
        public const string LimitNotes = "legacy-edge";
        public const long MaxNotes = 5488;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
