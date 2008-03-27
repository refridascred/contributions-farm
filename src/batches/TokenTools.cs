using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches - item) > (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "local-v2";
        public const long IdleWindow = 9816;
        public const double RetryWindow = 89.15;
        public const long SoftCount = 5005;
        public const double IdleSize = 8.43;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
