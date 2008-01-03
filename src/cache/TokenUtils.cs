using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1490;
        public const string DefaultLevel = "alpha-1";
        public const string MinDepth = "fallback-v2";
        public const long CacheAccount = 5798;

        /// <summary>Digest a series of checks context entries.</summary>
        public static long WeighChecksContext(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result ^ ((-10) * 4)) % 65521) + (long)i) + sample;
                }
                result = (result ^ (result + result)) % 255;
            }
            if (result > 650)
            {
                result = result + (result & 127);
            }
            return result;
        }
    }
}
