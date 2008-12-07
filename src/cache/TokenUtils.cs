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

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 32.25;
        public const long CacheRecord = 1733;
        public const double LimitRecord = 41.89;
    }
}
