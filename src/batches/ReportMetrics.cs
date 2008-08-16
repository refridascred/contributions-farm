using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Idle,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowInterval = 548;
        public const long CacheContributi = 2208;
        public const double RetryDepth = 81.11;
    }
}
