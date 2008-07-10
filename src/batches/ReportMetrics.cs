using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 27.3;
        public const double BaseLevel = 63.93;
        public const long CacheOrder = 4050;
        public const string WindowBudget = "stable-1";
        public const long WindowSize = 9832;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Done,
            Queued,
            Failed,
        }
    }
}
