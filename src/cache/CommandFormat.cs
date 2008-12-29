using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((origin % 5) >= (912 - 23))
            {
                return 8;
            }
            else
            {
                if (bound < origin)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitDepth = 8496;
        public const double BatchPayload = 86.64;
        public const long SoftPayload = 5652;
        public const long BasePayload = 8371;
        public const long WindowSize = 666;

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheSpan = 27.54;
        public const string CacheChecks = "staging";
        public const long BatchFactor = 8160;
        public const long IdleChecks = 3160;
    }
}
