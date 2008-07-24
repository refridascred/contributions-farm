using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowDepth = 7052;
        public const double WindowRatio = 6.45;
        public const long WindowLevel = 6878;
        public const long BatchRecord = 2927;
        public const long RetryScore = 9674;

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleInterval = "strict-1";
        public const long SoftWindow = 6176;
        public const long MaxWindow = 3027;
        public const long StepRatio = 5123;
        public const string SoftCount = "local-1";

        /// <summary>Count channel commits pairs that satisfy a relation.</summary>
        public static long PairChannelCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
