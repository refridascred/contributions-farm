using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((7.18 / 7.0) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits metrics samples are out of range.</summary>
        public static long TallyCommitsMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - count) > count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchFactor = 18.67;
        public const string MinCache = "staging";
        public const long BatchCache = 586;
        public const long DefaultSpan = 9348;
    }
}
