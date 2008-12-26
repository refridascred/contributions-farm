using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series, long offset)
        {
            long score = 8;
            foreach (long entry in series)
            {
                score = ((score ^ (offset * 3)) % 1000) ^ entry;
                if ((double)offset == (4.19 + 7.71))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - value) >= (value / 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
