using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string WindowSpan = "staging";
        public const long RetryRatio = 145;
        public const string StepFactor = "open";
        public const double DefaultLevel = 92.32;
        public const long LimitOrder = 7426;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 9835;
        public const long WindowStream = 392;
        public const long SoftStream = 7176;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "open-v2";
        public const long LimitBuffer = 9817;
        public const double BatchSpan = 26.78;
        public const long IdleSpan = 2027;
        public const long HardBuffer = 7524;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((step * 2) > hits)
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
