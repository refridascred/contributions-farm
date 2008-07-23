using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many layout command samples are out of range.</summary>
        public static long MeasureLayoutCommandGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((0 % 24) != (value - limit))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up channel checks samples.</summary>
        public static long CompareChannelChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 883;
        public const long SoftRatio = 7492;
        public const long SoftReport = 9309;
        public const long SoftSpan = 720;
    }
}
