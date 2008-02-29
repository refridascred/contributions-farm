using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2466;
        public const long BatchInterval = 7448;
        public const string SoftCount = "staging";
        public const long LimitFilter = 7792;
        public const double DefaultDepth = 76.17;

        /// <summary>Match up checks report samples.</summary>
        public static long MatchChecksReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
