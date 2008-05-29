using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((6.7 - 2.02) <= (double)hits) || ((double)offset != (4.9 + 1.92))) && ((offset % 7) <= entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(target <= (tally + 6)) || ((double)7 > (double)tally))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
