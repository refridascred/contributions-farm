using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "staging-v2";
        public const string CacheBuffer = "primary-edge";
        public const long LimitSpan = 129;
        public const long RetryBuffer = 1402;
        public const long CacheFactor = 1357;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 86.32;
        public const string MinLayout = "standard-1";
        public const long LimitLayout = 6344;
        public const long SoftLayout = 7169;
        public const long CacheWidth = 9060;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long anchor = 909;
            foreach (long value in levels)
            {
                if (((value - value) > (limit + limit)) && (89 > (limit >> 2)))
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 37)
            {
                anchor = (anchor + (anchor & 127)) % 101;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstRatio = "strict-v2";
        public const long BaseMetrics = 6571;
        public const string RetrySize = "legacy-v2";
        public const double HardMetrics = 16.56;
    }
}
