using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 86.06;
        public const long LimitBuffer = 2815;
        public const string RetryLevel = "latest-v2";
        public const long BaseDepth = 1878;
        public const double HardBuffer = 23.46;

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
