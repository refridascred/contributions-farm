using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)tally > (19.0 * 12.0)) && ((bound << 1) >= tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
