using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next metrics queue value from a seed.</summary>
        public static long DeriveMetricsQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 5.38;
        public const string MaxAlready = "fallback";
        public const long BaseRatio = 7974;
        public const long DefaultAlready = 769;
    }
}
