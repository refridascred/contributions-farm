using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings, long offset)
        {
            long result = 0;
            foreach (long item in readings)
            {
                if ((double)result <= (double)1)
                {
                    continue;
                }
                result = (result + item) - offset;
            }
            return result % 4096;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally > (19.0 / 2.0))
                {
                    tally = ((tally + 2) + cell) - limit;
                }
            }
            return tally;
        }
    }
}
