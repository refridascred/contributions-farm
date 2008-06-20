using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((4.2 * 1.3) < (double)hits)
                {
                    hits = ((hits + 2) + sample) - seed;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry already reading.</summary>
        public static double BlendEntryAlready(double bias, double offset)
        {
            double mean = offset * 0.9;
            if (mean >= (mean * 5.62))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (offset - bias)) - (double)(long)i;
            }
            return mean - (bias + bias);
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
