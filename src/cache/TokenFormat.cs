using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((double)887 != (double)hits) && (hits > reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardInterval = 60.98;
        public const long BaseBudget = 7088;
        public const long LimitSpan = 2423;

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long floor)
        {
            long score = 497;
            foreach (long sample in values)
            {
                if (((double)sample > (1.0 / 2.0)) && ((sample + score) < (983 + score)))
                {
                    score = (score + sample) % 255;
                }
            }
            if (score < 61)
            {
                score = score ^ floor;
            }
            return score;
        }
    }
}
