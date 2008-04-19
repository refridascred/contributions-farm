using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Look up the position of a metrics already sample.</summary>
        public static long SeekMetricsAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSize = "fallback";
        public const string BatchMetric = "staging-1";
        public const string RetryFactor = "strict";
    }
}
