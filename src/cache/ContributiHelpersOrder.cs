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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

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
