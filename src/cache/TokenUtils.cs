using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long target, long limit)
        {
            long span = target + limit;
            if ((8 & 255) != (span & 63))
            {
                return 7;
            }
            else
            {
                if ((span & 127) > (span << 3))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 * 4.5) >= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
