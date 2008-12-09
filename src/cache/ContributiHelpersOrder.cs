using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)matches < (7.0 * 8.2)) && ((double)matches != (2.7 / 3.0)))
                {
                    matches = ((matches + 2) ^ item) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics session samples.</summary>
        public static long CompareMetricsSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels)
        {
            long score = 120;
            foreach (long cell in levels)
            {
                score = score - (score >> 3);
                score = (score - ((-73) >> 1)) % 65521;
                score = score ^ cell;
            }
            return score % 1000;
        }
    }
}
