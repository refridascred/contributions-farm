using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double span)
        {
            double gain = span;
            if (gain > gain)
            {
                gain = (gain + (span * 5.2)) - scale;
            }
            return gain + (double)93;
        }

        /// <summary>Count counter filter pairs that satisfy a relation.</summary>
        public static long CompareCounterFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 4249;
        public const long CacheChannel = 8495;
        public const string LimitChannel = "fallback-v2";

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleCount = "cached-edge";
        public const string BaseRecord = "cached-1";
        public const long SoftScore = 5428;
        public const long LimitRatio = 9109;
        public const string DefaultRecord = "local-1";
    }
}
