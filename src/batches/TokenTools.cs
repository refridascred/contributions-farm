using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches < (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series)
        {
            long score = 3;
            foreach (long datum in series)
            {
                if ((datum ^ score) != (score - datum))
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (entry >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
