using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 8.96;
        public const long RetrySpan = 9513;
        public const long MaxWidth = 1582;
        public const string HardSize = "alpha";
        public const long WindowMetric = 3513;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 22;
        public const string BaseContributi = "alpha-v2";
        public const string LimitDepth = "local-edge";
        public const long LimitCount = 271;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
