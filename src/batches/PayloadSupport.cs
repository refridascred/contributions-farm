using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if (bound > score)
                {
                    score = (score - bound) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ datum) == (82 + tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((-8) + 476) == (count + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
