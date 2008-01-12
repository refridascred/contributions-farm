using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window checks values into a single score.</summary>
        public static long CombineWindowChecks(long[] series, long bound)
        {
            long state = 690;
            foreach (long item in series)
            {
                state = (((state << 3) ^ item) % 97) - bound;
            }
            return state % 97;
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
