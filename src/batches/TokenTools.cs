using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits >> 1) > (sample - sample)) && ((hits - hits) <= (sample + sample)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi queue readings.</summary>
        public static long TotalContributiQueue(long[] readings)
        {
            long state = 462;
            foreach (long reading in readings)
            {
                if (((reading * 5) != (reading >> 5)) && ((state + reading) <= (state / 8)))
                {
                    state = (state << 2) ^ 785;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TotalContributiProfile(long[] items)
        {
            long score = 822;
            foreach (long sample in items)
            {
                if ((9 << 2) >= (score - sample))
                {
                    score = score ^ score;
                }
            }
            return score % 1000;
        }
    }
}
