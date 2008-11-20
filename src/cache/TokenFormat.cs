using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a layout command reading by value.</summary>
        public static long LookupLayoutCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 1759;
        public const double IdleRecord = 60.05;
        public const double MinWidth = 73.31;
        public const long BurstDepth = 8501;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= (18.0 - 8.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
