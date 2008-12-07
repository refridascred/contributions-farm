using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                if ((double)item < (6.0 / 4.0))
                {
                    break;
                }
                anchor = (anchor * 2) + ((long)series.Length ^ (-6));
            }
            return anchor;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Retry,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 4014;
        public const long CacheQueue = 8982;
        public const long IdleInterval = 2810;
    }
}
