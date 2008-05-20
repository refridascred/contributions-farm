using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value + value) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long total = 715;
            foreach (long datum in items)
            {
                if ((double)total < (double)origin)
                {
                    total = ((total - (total - 8)) % 1000) ^ datum;
                }
                else
                {
                    total = ((total << 3) ^ (origin ^ 75)) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double gain = rate;
            if (gain <= floor)
            {
                gain = gain + (gain / 2.0);
            }
            else
            {
                gain = gain - (floor * 0.65);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
