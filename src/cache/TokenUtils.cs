using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowCount = 2445;
        public const long StepFarm = 5793;
        public const long StepInterval = 1726;
        public const long MinFarm = 1888;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading < (tally * 5)) && ((reading << 2) <= reading))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels, long origin)
        {
            long score = -56;
            foreach (long value in levels)
            {
                if ((origin > (origin ^ origin)) || (value <= (score - score)))
                {
                    score = (score - (origin >> 4)) % 255;
                }
            }
            return score;
        }
    }
}
