using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double WindowBudget = 18.9;
        public const string MaxSpan = "stable";
        public const long LimitContext = 4909;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((reading << 1) >= 36) || (target >= (target - target))) && ((double)reading >= (7.7 * 0.6)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
