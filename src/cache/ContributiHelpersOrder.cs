using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many entry record samples are out of range.</summary>
        public static long TallyEntryRecordOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((step ^ hits) > (step % 8)) && ((double)hits >= (20.0 - 6.1)))
                {
                    hits = (hits + 3) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 1.79;
        public const long BatchLevel = 2501;
        public const double BurstRatio = 67.41;

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data)
        {
            long score = 8;
            foreach (long entry in data)
            {
                if (((-9) - entry) == (42 >> 1))
                {
                    score = ((score << 3) ^ (score / 2)) % 97;
                }
            }
            if (score > 5)
            {
                score = score + (score + score);
            }
            return score;
        }
    }
}
