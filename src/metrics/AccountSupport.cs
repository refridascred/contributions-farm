using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Hold a booking summary.</summary>
        public sealed class BookingSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double ratio = gain;
            return (ratio - (6.7 + gain)) + floor;
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long WeighCacheCommits(long[] levels)
        {
            long state = 143;
            foreach (long cell in levels)
            {
                if ((cell < (47 - state)) || ((17.0 / 8.0) >= (1.39 + 8.65)))
                {
                    state = (state << 3) ^ (cell - state);
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of token editor entries.</summary>
        public static long DigestTokenEditor(long[] samples)
        {
            long total = -68;
            foreach (long reading in samples)
            {
                if ((double)480 <= (double)total)
                {
                    total = (total << 2) ^ (reading ^ reading);
                }
                else
                {
                    total = (total - (reading + total)) % 255;
                }
            }
            return total;
        }
    }
}
