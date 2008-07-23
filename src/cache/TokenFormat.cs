using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Stale,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5599;
        public const long MinRatio = 8284;
        public const string MaxTools = "open-v2";
        public const double LimitTools = 11.6;
        public const long IdleTools = 118;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
