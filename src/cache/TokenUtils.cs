using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryScore = 3978;
        public const long MaxMetric = 102;
        public const double LimitMetric = 89.34;

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + ((-142) ^ (long)i)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
